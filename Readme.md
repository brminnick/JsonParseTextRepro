# Json Parse Text Repro

A reproduction sample demonstrating a regression in Visual Studio for Mac v8.3 Preview 4.

Issue reported to the Xamarin.Android team: https://github.com/xamarin/xamarin-android/issues/3626

| VS for Mac v8.2.6 (build 28) | VS for Mac v8.3 (build 1630)|
| ---------------------------- | --------------------------- |
| ![](https://user-images.githubusercontent.com/13558917/64836161-b84ac380-d59d-11e9-90ee-458ab5e2a4fe.png) | ![](https://user-images.githubusercontent.com/13558917/64835332-7f5d1f80-d59a-11e9-98c3-298ebc1d89aa.png) | 

## Reproduction Steps

1. Install the VS for Mac Preview Build available on 13 September 0300 UTC ([Environment](#environment) information, below)
2. In Visual Studio for Mac, Open JsonParseTextRepro.sln
3. Set the Build Configration to DEBUG
4. Build/Deploy the JsonParseTextRepro.Android project to an Android Emulator or Physical Device
5. Verify display shows the following Exception: `Newtonsoft.Json.JsonReaderException`

## Work Around

1. Install the VS for Mac Stable Build available on 13 September 0300 UTC, VS for Mac v8.2.6 (build 28)
2. In Visual Studio for Mac, Open JsonParseTextRepro.sln
3. Set the Build Configration to DEBUG
4. Build/Deploy the JsonParseTextRepro.Android project to an Android Emulator or Physical Device
5. Verify the display shows `Success`

## Environment

=== Visual Studio Enterprise 2019 for Mac (Preview) ===

Version 8.3 Preview (8.3 build 1630)
Installation UUID: 6e5142b4-e8be-4d1c-b75e-4744b0d8c3de
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 5.16.1.24 (d16-3 / 08809f5b)

	Package version: 604000190

=== Mono Framework MDK ===

Runtime:
	Mono 6.4.0.190 (2019-06/6b4b99e571b) (64-bit)
	Package version: 604000190

=== NuGet ===

Version: 5.3.0.6192

=== .NET Core ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.0.0-preview9-19423-09
	3.0.0-preview6-27804-01
	2.2.5
	2.1.9
	2.1.2
	2.1.1
	2.0.5
	2.0.0
	1.1.1
	1.0.4
SDK: /usr/local/share/dotnet/sdk/3.0.100-preview9-014004/Sdks
SDK Versions:
	3.0.100-preview9-014004
	3.0.100-preview6-012264
	2.2.107
	2.1.505
	2.1.302
	2.1.301
	2.1.4
	2.0.0
	1.0.1
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.4.0/lib/mono/msbuild/Current/bin/Sdks

=== Xamarin.Profiler ===

Version: 1.6.11.16
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Xamarin.Android ===

Version: 10.0.0.40 (Visual Studio Enterprise)
Commit: xamarin-android/d16-3/080eaac
Android SDK: /Users/brandonm/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		None installed

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 28.0.2
SDK Build Tools Version: 28.0.3

Build Information: 
Mono: mono/mono/2019-06@6434153d8b7
Java.Interop: xamarin/java.interop/d16-3@5836f58
LibZipSharp: grendello/LibZipSharp/d16-3@71f4a94
LibZip: nih-at/libzip/rel-1-5-1@b95cf3f
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.27.1@8212a2d
Xamarin.Android Tools: xamarin/xamarin-android-tools/d16-3@cb41333

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/brandonm/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 1.4.0.64
Hash: f70cfd2
Branch: remotes/origin/d16-3
Build date: 2019-09-02 17:32:00 UTC

=== Android Device Manager ===

Version: 1.2.0.112
Hash: 791e68e
Branch: remotes/origin/d16-3
Build date: 2019-09-02 17:32:26 UTC

=== Xamarin Designer ===

Version: 16.3.0.178
Hash: 725c87d57
Branch: remotes/origin/d16-3
Build date: 2019-08-29 22:57:50 UTC

=== Apple Developer Tools ===

Xcode 11.0 (14935)
Build 11A419c

=== Xamarin.Mac ===

Version: 5.16.1.24 (Visual Studio Enterprise)
Hash: 08809f5b
Branch: d16-3
Build date: 2019-09-06 08:42:41-0400

=== Xamarin.iOS ===

Version: 12.16.1.24 (Visual Studio Enterprise)
Hash: 08809f5b
Branch: d16-3
Build date: 2019-09-06 08:42:42-0400

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 803001630
Git revision: 456143789d948850ef2518c7401bcd0637d88e99
Build date: 2019-09-11 21:24:24+00
Build branch: release-8.3-preview4
Xamarin extensions: 52c395755d16d1c7077d3568574a19af9a23b423

=== Operating System ===

Mac OS X 10.15.0
Darwin 19.0.0 Darwin Kernel Version 19.0.0
    Sun Aug 18 23:37:31 PDT 2019
    root:xnu-6153.0.166~17/RELEASE_X86_64 x86_64

