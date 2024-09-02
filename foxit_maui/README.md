# Foxit PDF SDK for .NET MAUI
------
Foxit PDF SDK for .NET features a powerful, easy-to-use Core API in C# for rendering, viewing, annotation, signing, protecting and managing forms in PDFs. This sample project works with the  `Foxit PDF SDK for Android/iOS` and is a direct port of the `complete_pdf_viewer`  sample project included in the RDK.


## Supported platforms

------

| Platform | System Requirements                                  |
| -------- | ---------------------------------------------------- |
| iOS      | iOS 11 or higher, using the latest release of XCode. |
| Android  | Android 4.4 (API 19) or higher.                      |


## Getting Started
------

### Android
* **How to run the foxit maui.**


  1. Go to https://github.com/foxitsoftware/xamarin-foxitpdf/tree/master
  2. Click on "Code", Click on "Download zip"
  3. Unzip xamarin-foxitpdf-master.zip to any directory
  4. Confirm Android 4.4 or higher is installed.  If not, please update or install.
  5. Open Android Studio make sure you have a emulator created. If not create one.  For my test, I have "Pixel 5 - API 33 (Android 13.0 - API 33)"
  6. Start the emulator from Android Studio's Deivce Manager.
  7. Request for a trial of Foxit PDF SDK for Android 9.0.  Download and unzip the trial package foxitpdfsdk_9_0_android.zip
  8. Copy foxitpdfsdk_9_0_android\libs\rdk_sn.txt and foxitpdfsdk_9_0_android\libs\rdk_key.txt to xamarin-foxitpdf-master\foxit_xamarin_android\libs
  9. Open xamarin-foxitpdf-master\foxit_maui\foxit_maui.sln with Visual Studio 2022 or higher
  10. Open the "Solution Explorer" right click on the foxit_menu project and select "Manage Nuget Packages"
  11. Click on "Installed" Confirm that Foxit.Android 9.0.0 and Foxit.Android.UIExtensions 9.0.0 are installed. If not, install them.
  12. In the Configuration Manager, select the emulated device from step 5.
  13. Click Debug -> "Start Without Debugging."
  14. Select a PDF and open it.

### iOS
* [Install Foxit.iOS](https://www.nuget.org/packages/Foxit.iOS)
* [Install Foxit.iOS.UIExtensions](https://www.nuget.org/packages/Foxit.iOS.UIExtensions)
* [Install Foxit.iOS.Scanning.UI](https://www.nuget.org/packages/Foxit.iOS.Scanning.UI)

## More
------------
We also provide another demo that can support more platforms, you can refer to the [FoxitPDFSDKForMAUI](https://github.com/foxitsoftware/FoxitPDFSDKForMAUI) for more information





