# foxit_xamarin_ios
Use the Foxit Mobile PDF SDK with Xamarin on iOS

Now we had support rdk 6.4.0

## Introduction

This sample project works with the  `Foxit PDF SDK for iOS 6.4` and is a direct port of the `FoxitRDKDemo`  sample project included in the RDK.

## Installation

### Install By NuGet

1: If you have already add reference `FoxitRDK.dll`, please remove them first.

2: Right-click the References node of the `FoxitRDKDemo`  project and select Manager NuGet Packages...

3: Select the `Browse` tab, search for `Foxit.iOS`, `Foxit.iOS.UIExtensions` install.

4: If you do not already have a valid Foxit license key, please download `foxitpdfsdk_(version_no)_ios.zip` from [https://developers.foxitsoftware.com/pdf-sdk/ios/](https://developers.foxitsoftware.com/pdf-sdk/ios/) to get the key.

5: unzip the `foxitpdfsdk_(version_no)_ios.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_ios/libs` directory:

* `rdk_key.txt`
* `rdk_sn.txt`

6: `Run` the `FoxitRDKDemo` project in the simulator or on a physical device.

### Install By Reference

1: If you have already add NuGet `Foxit.iOS`, `Foxit.iOS.UIExtensions`, please remove them first

2: Download `foxitpdfsdk_(version_no)_ios.zip` from [https://developers.foxitsoftware.com/pdf-sdk/ios/](https://developers.foxitsoftware.com/pdf-sdk/ios/)

3: unzip the `foxitpdfsdk_(version_no)_ios.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_ios/libs` directory:

* `FoxitRDK.framework`
* `uiextensionsDynamic.framework`
* `rdk_key.txt`
* `rdk_sn.txt`

4: Click the `Foxit.iOS.UIExtensions.sln`

5: `Rebuild` the `Foxit.iOS` , `Foxit.iOS.UIExtensions`

6: Click the `FoxitRDKDemo.sln`

7: Add the `Foxit.iOS`,`Foxit.iOS.UIExtensions` project or `dll-files`.

8: `Run` the `FoxitRDKDemo` project in the simulator or on a physical device.
