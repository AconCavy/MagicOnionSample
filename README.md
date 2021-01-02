# MagicOnion Sample

## Environment

- Client
    - Unity 2019.4.17f1
- Server
    - .NET Core 3.1
  
## Dependency

- MagicOnion 4.0.4
- MessagePack for C# 2.2.85
- Grpc (grpc_unity_package.2.35.0-dev202012021242)

## Setup

1. Download and install the MagicOnion and MessagePack for C# to the Unity project.
1. Download and extract the Grpc for unity and copy the `Google.Protobuf`, `Grpc.Core`, and `Grpc.Core.Api` to the `Assets/Plugins` on the Unity.
1. Update an assembly definition references of the `MagicOnion.Client.asmdef` to add `MessagePack.Annotations`.

## Start

1. Run the MagicOnionSample.Server on the .NET runtime.
1. Run the MagicOnionSample.Unity on the Unity.

## Http

The projects use HTTP unencrypted connection without TLS.
You should read a [MagicOnion HTTPS section](https://github.com/Cysharp/MagicOnion#https-tls) if you used Https.