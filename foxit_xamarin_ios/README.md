# foxit_xamarin_ios
Use the Foxit Mobile PDF SDK with Xamarin on iOS

Introduction
------------

This sample project works with the Foxit RDK v5 and is a direct port of the `complete_pdf_viewer` Objective-C sample project included in the RDK.

Setup
-----

The sample project is ready to run but it requires the addition of three files. These files should be placed into the `libs` directory:

* `FoxitRDK.framework`
* `libFoxitRDKUIExtensions.a`	
* `rdk_key.txt`
* `rdk_sn.txt`

Once the files have been added the `FoxitRDKDemo.sln` project file can be loaded into Visual Studio for Mac and run in the simulator or on a physical device.
