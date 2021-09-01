# foxit_xamarin_ios
Use the Foxit Mobile PDF SDK with Xamarin on iOS

Now we had support rdk 8.1

## Introduction

This sample project works with the  `Foxit PDF SDK for iOS 8.1` and is a direct port of the `FoxitRDKDemo`  sample project included in the RDK.

## Installation

### Install By NuGet

1: If you have already add reference `FoxitRDK.dll`, please remove them first.

2: Right-click the References node of the `FoxitRDKDemo`  project and select Manager NuGet Packages...

3: Select the `Browse` tab, search for `Foxit.iOS`, `Foxit.iOS.UIExtensions` and`Foxit.iOS.Scanning.UI`install.

4: If you do not already have a valid Foxit license key, please download `foxitpdfsdk_(version_no)_ios.zip` from [https://developers.foxitsoftware.com/pdf-sdk/ios/](https://developers.foxitsoftware.com/pdf-sdk/ios/) to get the key.

5: unzip the `foxitpdfsdk_(version_no)_ios.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_ios/libs` directory:

* `rdk_key.txt`
* `rdk_sn.txt`

6: `Run` the `FoxitRDKDemo` project in the simulator or on a physical device.

### Install By Reference

1: If you have already add NuGet `Foxit.iOS`, `Foxit.iOS.UIExtensions`and`Foxit.iOS.Scanning.UI`, please remove them first

2: Download `foxitpdfsdk_(version_no)_ios.zip` from [https://developers.foxitsoftware.com/pdf-sdk/ios/](https://developers.foxitsoftware.com/pdf-sdk/ios/)

3: unzip the `foxitpdfsdk_(version_no)_ios.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_ios/libs` directory:

* `FoxitRDK.framework`
* `uiextensionsDynamic.framework`
* `FoxitPDFScanUI.framework`
* `rdk_key.txt`
* `rdk_sn.txt`

4: Click the `Foxit.iOS.UIExtensions.sln`

5: `Rebuild` the `Foxit.iOS` , `Foxit.iOS.UIExtensions`and`Foxit.iOS.Scanning.UI`.

6: Click the `FoxitRDKDemo.sln`

7: Add the `Foxit.iOS`,`Foxit.iOS.UIExtensions`,`Foxit.iOS.Scanning.UI` project or `dll-files`.

8: `Run` the `FoxitRDKDemo` project in the simulator or on a physical device.


## How to update api definition
Download[objective-sharpie](https://docs.microsoft.com/en-us/xamarin/cross-platform/macios/binding/objective-sharpie/releases/)
1. Download `foxitpdfsdk_(version_no)_ios.zip` from [https://developers.foxitsoftware.com/pdf-sdk/ios/](https://developers.foxitsoftware.com/pdf-sdk/ios/)
2. Unzip the `foxitpdfsdk_(version_no)_ios.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_ios/libs` directory:
3. Modify the native to the Xcode SDK version
```ruby
$ sharpie xcode -sdks sdk: iphoneos12.1     arch: arm64
```
Respectively```FoxitRDK.framework/Info.plist```、```uiextensionsDynamic.framework/Info.plist``、```uiextensionsDynamic.framework/Info.plist````and```sharpie_bind_framework.py```  ```DTSDKName```、```DTPlatformVersion```and```sdk_version```change to the version of the local environment.（iphoneos14.5，14.5)
4. If a new class needs to be added in``ApiDefinitionAppending``, if a new enumeration type needs to be added in``StructsAppending``,the compiler error needs to add a new rule in``replace_api.py``.

### The last
```ruby
$ cd ./replace_api
$ python sharpie_bind_framework.py
```


### Direct use of biplist:
Install biplist relies on Python
1. Same as above
2. Same as above
3. If a new class needs to be added in``ApiDefinitionAppending``, if a new enumeration type needs to be added in``StructsAppending``,the compiler error needs to add a new rule in``replace_api.py``.
```ruby
$ python biplist_sharpie_bind_framework.py
```
