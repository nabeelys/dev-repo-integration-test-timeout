﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using System;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A simple rate limiter that will allow tracing based on a given QPS.
    /// </summary>
    internal sealed class RateLimiter
    {
        /// <summary>A mutex to protect the rate limiter instance.</summary>
        private static readonly object _instanceMutex = new object();

        /// <summary>The single rate limiter instance.</summary>
        private static RateLimiter _instance;

        /// <summary>The amount of time that must be waited before allowing tracing.</summary>
        private readonly long _fixedDelayMillis;

        /// <summary>A timer to manage time between events.</summary>
        private readonly ITimer _timer;

        /// <summary>The last time tracing was allowed.</summary>
        private long _lastCallMillis;

        private readonly object _lastCallMutex = new object();

        /// <summary>
        /// Gets the instance of the <see cref="RateLimiter"/>.  The first request will set the
        /// QPS of the rate limiter.  All subsequent request's QPS will not change the QPS of the rate limiter.
        /// </summary>
        public static RateLimiter GetInstance(double qps)
        {
            lock (_instanceMutex)
            {
                if (_instance == null)
                {
                    _instance = new RateLimiter(qps, StopwatchTimer.Create());
                }
            }
            return _instance;
        }

        internal RateLimiter(double qps, ITimer timer)
        {
            GaxPreconditions.CheckArgument(qps >= 0, nameof(qps), "qps must be greater than or equal to 0");

            _timer = timer;
            _timer.Start();

            if (qps == 0)
            {
                _fixedDelayMillis = long.MaxValue;
            }
            else
            {
                _fixedDelayMillis = (1000 / qps) switch
                {
                    double millis when millis > long.MaxValue || millis > TimeSpan.MaxValue.TotalMilliseconds => long.MaxValue,
                    double millis => Convert.ToInt64(millis)
                };
            }

            // Allow a trace immediately.
            _lastCallMillis = -_fixedDelayMillis;
        }

        /// <summary>
        /// See if tracing is allowed.  If tracing is allowed, tracing will not be allowed to occur 
        /// again until the allotted time (1/qps) has passed.
        /// </summary>
        /// <returns>True if tracing is allowed.</returns>
        public bool CanTrace()
        {
            if (_fixedDelayMillis == 0)
            {
                return true;
            }
            if (_fixedDelayMillis == long.MaxValue)
            {
                return false;
            }

            lock (_lastCallMutex)
            {
                var nowMillis = _timer.GetElapsedMilliseconds();
                if (nowMillis - _lastCallMillis >= _fixedDelayMillis)
                {
                    _lastCallMillis = nowMillis;
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Reset the rate limiter instance to null.  This will allow a new QPS rate limit to
        /// be set.  For testing use only.
        /// </summary>
        internal static void Reset()
        {
            lock (_instanceMutex)
            {
                _instance = null;
            }
        }
    }
}