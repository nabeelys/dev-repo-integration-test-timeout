// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/gaming/v1beta/game_server_clusters_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Gaming.V1Beta {

  /// <summary>Holder for reflection information generated from google/cloud/gaming/v1beta/game_server_clusters_service.proto</summary>
  public static partial class GameServerClustersServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/gaming/v1beta/game_server_clusters_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameServerClustersServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvY2xvdWQvZ2FtaW5nL3YxYmV0YS9nYW1lX3NlcnZlcl9jbHVz",
            "dGVyc19zZXJ2aWNlLnByb3RvEhpnb29nbGUuY2xvdWQuZ2FtaW5nLnYxYmV0",
            "YRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9j",
            "bGllbnQucHJvdG8aNWdvb2dsZS9jbG91ZC9nYW1pbmcvdjFiZXRhL2dhbWVf",
            "c2VydmVyX2NsdXN0ZXJzLnByb3RvGiNnb29nbGUvbG9uZ3J1bm5pbmcvb3Bl",
            "cmF0aW9ucy5wcm90bzLfEQoZR2FtZVNlcnZlckNsdXN0ZXJzU2VydmljZRLl",
            "AQoWTGlzdEdhbWVTZXJ2ZXJDbHVzdGVycxI5Lmdvb2dsZS5jbG91ZC5nYW1p",
            "bmcudjFiZXRhLkxpc3RHYW1lU2VydmVyQ2x1c3RlcnNSZXF1ZXN0GjouZ29v",
            "Z2xlLmNsb3VkLmdhbWluZy52MWJldGEuTGlzdEdhbWVTZXJ2ZXJDbHVzdGVy",
            "c1Jlc3BvbnNlIlSC0+STAkUSQy92MWJldGEve3BhcmVudD1wcm9qZWN0cy8q",
            "L2xvY2F0aW9ucy8qL3JlYWxtcy8qfS9nYW1lU2VydmVyQ2x1c3RlcnPaQQZw",
            "YXJlbnQS0gEKFEdldEdhbWVTZXJ2ZXJDbHVzdGVyEjcuZ29vZ2xlLmNsb3Vk",
            "LmdhbWluZy52MWJldGEuR2V0R2FtZVNlcnZlckNsdXN0ZXJSZXF1ZXN0Gi0u",
            "Z29vZ2xlLmNsb3VkLmdhbWluZy52MWJldGEuR2FtZVNlcnZlckNsdXN0ZXIi",
            "UoLT5JMCRRJDL3YxYmV0YS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8q",
            "L3JlYWxtcy8qL2dhbWVTZXJ2ZXJDbHVzdGVycy8qfdpBBG5hbWUStAIKF0Ny",
            "ZWF0ZUdhbWVTZXJ2ZXJDbHVzdGVyEjouZ29vZ2xlLmNsb3VkLmdhbWluZy52",
            "MWJldGEuQ3JlYXRlR2FtZVNlcnZlckNsdXN0ZXJSZXF1ZXN0Gh0uZ29vZ2xl",
            "LmxvbmdydW5uaW5nLk9wZXJhdGlvbiK9AYLT5JMCWiJDL3YxYmV0YS97cGFy",
            "ZW50PXByb2plY3RzLyovbG9jYXRpb25zLyovcmVhbG1zLyp9L2dhbWVTZXJ2",
            "ZXJDbHVzdGVyczoTZ2FtZV9zZXJ2ZXJfY2x1c3RlctpBMXBhcmVudCxnYW1l",
            "X3NlcnZlcl9jbHVzdGVyLGdhbWVfc2VydmVyX2NsdXN0ZXJfaWTKQSYKEUdh",
            "bWVTZXJ2ZXJDbHVzdGVyEhFPcGVyYXRpb25NZXRhZGF0YRKXAgoeUHJldmll",
            "d0NyZWF0ZUdhbWVTZXJ2ZXJDbHVzdGVyEkEuZ29vZ2xlLmNsb3VkLmdhbWlu",
            "Zy52MWJldGEuUHJldmlld0NyZWF0ZUdhbWVTZXJ2ZXJDbHVzdGVyUmVxdWVz",
            "dBpCLmdvb2dsZS5jbG91ZC5nYW1pbmcudjFiZXRhLlByZXZpZXdDcmVhdGVH",
            "YW1lU2VydmVyQ2x1c3RlclJlc3BvbnNlIm6C0+STAmgiUS92MWJldGEve3Bh",
            "cmVudD1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlYWxtcy8qfS9nYW1lU2Vy",
            "dmVyQ2x1c3RlcnM6cHJldmlld0NyZWF0ZToTZ2FtZV9zZXJ2ZXJfY2x1c3Rl",
            "chL1AQoXRGVsZXRlR2FtZVNlcnZlckNsdXN0ZXISOi5nb29nbGUuY2xvdWQu",
            "Z2FtaW5nLnYxYmV0YS5EZWxldGVHYW1lU2VydmVyQ2x1c3RlclJlcXVlc3Qa",
            "HS5nb29nbGUubG9uZ3J1bm5pbmcuT3BlcmF0aW9uIn+C0+STAkUqQy92MWJl",
            "dGEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZWFsbXMvKi9nYW1l",
            "U2VydmVyQ2x1c3RlcnMvKn3aQQRuYW1lykEqChVnb29nbGUucHJvdG9idWYu",
            "RW1wdHkSEU9wZXJhdGlvbk1ldGFkYXRhEoICCh5QcmV2aWV3RGVsZXRlR2Ft",
            "ZVNlcnZlckNsdXN0ZXISQS5nb29nbGUuY2xvdWQuZ2FtaW5nLnYxYmV0YS5Q",
            "cmV2aWV3RGVsZXRlR2FtZVNlcnZlckNsdXN0ZXJSZXF1ZXN0GkIuZ29vZ2xl",
            "LmNsb3VkLmdhbWluZy52MWJldGEuUHJldmlld0RlbGV0ZUdhbWVTZXJ2ZXJD",
            "bHVzdGVyUmVzcG9uc2UiWYLT5JMCUypRL3YxYmV0YS97bmFtZT1wcm9qZWN0",
            "cy8qL2xvY2F0aW9ucy8qL3JlYWxtcy8qL2dhbWVTZXJ2ZXJDbHVzdGVycy8q",
            "fTpwcmV2aWV3RGVsZXRlErYCChdVcGRhdGVHYW1lU2VydmVyQ2x1c3RlchI6",
            "Lmdvb2dsZS5jbG91ZC5nYW1pbmcudjFiZXRhLlVwZGF0ZUdhbWVTZXJ2ZXJD",
            "bHVzdGVyUmVxdWVzdBodLmdvb2dsZS5sb25ncnVubmluZy5PcGVyYXRpb24i",
            "vwGC0+STAm4yVy92MWJldGEve2dhbWVfc2VydmVyX2NsdXN0ZXIubmFtZT1w",
            "cm9qZWN0cy8qL2xvY2F0aW9ucy8qL3JlYWxtcy8qL2dhbWVTZXJ2ZXJDbHVz",
            "dGVycy8qfToTZ2FtZV9zZXJ2ZXJfY2x1c3RlctpBH2dhbWVfc2VydmVyX2Ns",
            "dXN0ZXIsdXBkYXRlX21hc2vKQSYKEUdhbWVTZXJ2ZXJDbHVzdGVyEhFPcGVy",
            "YXRpb25NZXRhZGF0YRKsAgoeUHJldmlld1VwZGF0ZUdhbWVTZXJ2ZXJDbHVz",
            "dGVyEkEuZ29vZ2xlLmNsb3VkLmdhbWluZy52MWJldGEuUHJldmlld1VwZGF0",
            "ZUdhbWVTZXJ2ZXJDbHVzdGVyUmVxdWVzdBpCLmdvb2dsZS5jbG91ZC5nYW1p",
            "bmcudjFiZXRhLlByZXZpZXdVcGRhdGVHYW1lU2VydmVyQ2x1c3RlclJlc3Bv",
            "bnNlIoIBgtPkkwJ8MmUvdjFiZXRhL3tnYW1lX3NlcnZlcl9jbHVzdGVyLm5h",
            "bWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9yZWFsbXMvKi9nYW1lU2VydmVy",
            "Q2x1c3RlcnMvKn06cHJldmlld1VwZGF0ZToTZ2FtZV9zZXJ2ZXJfY2x1c3Rl",
            "chpPykEbZ2FtZXNlcnZpY2VzLmdvb2dsZWFwaXMuY29t0kEuaHR0cHM6Ly93",
            "d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9jbG91ZC1wbGF0Zm9ybUKBAQoeY29t",
            "Lmdvb2dsZS5jbG91ZC5nYW1pbmcudjFiZXRhUAFaQGdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvZ2FtaW5nL3YxYmV0YTtn",
            "YW1pbmfKAhpHb29nbGVcQ2xvdWRcR2FtaW5nXFYxYmV0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Cloud.Gaming.V1Beta.GameServerClustersReflection.Descriptor, global::Google.LongRunning.OperationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
