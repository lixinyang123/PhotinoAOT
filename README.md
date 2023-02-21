# PhotinoAOT

Photino.NET AOT Builder. `~1.7MB size`

![image](https://user-images.githubusercontent.com/32838371/220255338-31b198d5-8673-4a56-8b5e-d431b441e2fa.png)

You can disable UPX Compresse to get lower memory usage.

## Prerequisites

Windows

```bash
Visual Studio 2022, including Desktop development with C++ workload.
```

Ubuntu (20.04+)

```bash
sudo apt-get install libicu-dev cmake
```

## Publish with NativeAOT

```bash
dotnet publish -r <RID> -c Release

# Build for Windows example
dotnet publish -r win-x64 -c Release
```

## Builder the installer with NSIS

NSIS installer `~1.6MB usage`

```bash
pwsh ./publish.ps1
```

> if you builder the installer with nsis, you can ignore upx compression, so you can get better startup performance.

## Screenshot

![image](https://user-images.githubusercontent.com/32838371/220255518-13192476-e7a4-41b4-b9eb-37e62376b736.png)
