# Version history

## Version 2.1.0, released 2023-01-16

### New features

- Support AttachedClusters ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))
- Add errors output fields for cluster and nodepool resources ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))
- Add AWS Autoscaling Group metrics collection for AWS nodepools ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))
- Add monitoring config ([commit aee0849](https://github.com/googleapis/google-cloud-dotnet/commit/aee0849f0679a9557375d70887436926f6ec1c16))

## Version 2.0.0, released 2022-09-15

No API surface changes; just dependency updates and promotion to GA.

## Version 2.0.0-beta01, released 2022-06-09

This is the first version of this package to depend on GAX v4.

There are some breaking changes, both in GAX v4 and in the generated
code. The changes that aren't specific to any given API are [described in the Google Cloud
documentation](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax4).
We don't anticipate any changes to most customer code, but please [file a
GitHub issue](https://github.com/googleapis/google-cloud-dotnet/issues/new/choose)
if you run into problems.

The most important change in this release is the use of the Grpc.Net.Client package
for gRPC communication, instead of Grpc.Core. When using .NET Core 3.1 or .NET 5.0+
this should lead to a smaller installation footprint and greater compatibility (e.g.
with Apple M1 chips). Any significant change in a core component comes with the risk
of incompatibility, however - so again, please let us know if you encounter any
issues.

## Version 1.0.0-beta01, released 2022-05-12

Initial release.
