# foxit_xamarin_android
Use the Foxit Mobile PDF SDK with Xamarin on android

Introduction
------------

This sample project works with the  `Foxit RDK 6.2` and is a direct port of the `complete_pdf_viewer`  sample project included in the RDK.

Setup
-----
1: Download `foxit_mobile_pdf_sdk_android_en.zip` from [https://developers.foxitsoftware.com/pdf-sdk/android/](https://developers.foxitsoftware.com/pdf-sdk/android/)

2: unzip the `foxit_mobile_pdf_sdk_android_en.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_android/libs` directory:

* `FoxitRDK.aar`
* `FoxitRDKUIExtensions.aar`
* `rdk_key.txt`
* `rdk_sn.txt`

3: Click the `complete_pdf_viewer.sln`

4: `Rebuild` the `FoxitRDK` , `FoxitUIExtensions` and `Cropper` project

5: `Run` the `complete_pdf_viewer` project in the simulator or on a physical device.

License
-----

###lisense for Cropper
[https://github.com/edmodo/cropper](https://github.com/edmodo/cropper)

Copyright 2013, Edmodo, Inc.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this work except in compliance with the License. You may obtain a copy of the License in the LICENSE file, or at:

[http://www.apache.org/licenses/LICENSE-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
