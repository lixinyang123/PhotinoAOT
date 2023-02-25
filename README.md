# PhotinoAOT

Photino.NET AOT Builder. `~1.6MB size`

![image](https://user-images.githubusercontent.com/32838371/221382001-e7129318-38f6-4ada-814a-e44dd38d6733.png)

## Prerequisites

Windows

```bash
Visual Studio 2022, including .NET 8 & Desktop development with C++ workload.
```

Ubuntu (20.04+)

```bash
sudo apt-get install dotnet-sdk-8.0 libicu-dev cmake
```

## Publish with NativeAOT

```bash
dotnet publish -r <RID> -c Release

# Build for Windows example
dotnet publish -r win-x64 -c Release
```

## Builder the installer with NSIS

NSIS installer `~1.4MB size`

```bash
pwsh ./publish.ps1
```

> if you builder the installer with nsis, you can ignore upx compression, so you can get better startup performance.

## Screenshot

![image](https://user-images.githubusercontent.com/32838371/220255518-13192476-e7a4-41b4-b9eb-37e62376b736.png)
