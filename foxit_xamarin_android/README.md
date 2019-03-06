# foxit_xamarin_android
Use the Foxit PDF SDK for Android with Xamarin

Introduction
------------

This sample project works with the  `Foxit PDF SDK for Android 6.3` and is a direct port of the `complete_pdf_viewer`  sample project included in the RDK.

Installation
-----
1: Download `foxitpdfsdk_(version_no)_android.zip` from [https://developers.foxitsoftware.com/pdf-sdk/android/](https://developers.foxitsoftware.com/pdf-sdk/android/)

2: unzip the `foxitpdfsdk_(version_no)_android.zip`,and enter the `libs` directory,copy the following files  into the `foxit_xamarin_android/libs` directory:

* `FoxitRDK.aar`
* `FoxitRDKUIExtensions.aar`
* `rdk_key.txt`
* `rdk_sn.txt`

3: Click the `complete_pdf_viewer.sln`

4: `Rebuild` the `FoxitRDK` , `FoxitUIExtensions` and `Cropper` project

5: `Run` the `complete_pdf_viewer` project in the simulator or on a physical device.

####(Optional)   

If you want to open a RMS protected PDF file, you should:

1: `Rebuild` the `Microsoft_Aad_Aadl` , `RMSSDK` and `RMSSDK_UI` project.

2: Right-click the References node of the `complete_pdf_viewer`  project and select Add Reference...

3: Select the  `xxx\Microsoft_Aad_Aadl\obj\Debug\Microsoft_Aad_Aadl.dll` , `xxx\RMSSDK\obj\Debug\RMSSDK.dll` and `xxx\RMSSDK_UI\obj\Debug\RMSSDK_UI.dll` and click OK ( the `xxx` represents the file path).

4:` Run` the `complete_pdf_viewer` project in the simulator or on a physical device.
  

License
-----

###lisense for Cropper
[https://github.com/edmodo/cropper](https://github.com/edmodo/cropper)

Copyright 2013, Edmodo, Inc.

    Licensed under the Apache License, Version 2.0 (the "License"); you may not  
    use this work except in compliance with the License. You may obtain a copy  
    of the License in the LICENSE file, or at:
      
    http://www.apache.org/licenses/LICENSE-2.0  
      
    Unless required by applicable law or agreed to in writing, software   
    distributed under the License is distributed on an "AS IS" BASIS, WITHOUT   
    WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the   
    License for the specific language governing permissions and limitations   
    under the License.

###lisense for ADAL
[https://github.com/AzureAD/azure-activedirectory-library-for-android](https://github.com/AzureAD/azure-activedirectory-library-for-android)

Copyright (c) Microsoft Corporation.
     
    All rights reserved. This code is licensed under the MIT License.
      
    We Value and Adhere to the Microsoft Open Source Code of Conduct  
       
    This project has adopted the Microsoft Open Source Code of Conduct. For   
    more information see the Code of Conduct FAQ or contact opencode@microsoft  
    .com with any additional questions or comments.

###lisense for GSON
[https://github.com/google/gson](https://github.com/google/gson)

Copyright 2008 Google Inc.

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at  
      
      http://www.apache.org/licenses/LICENSE-2.0  
      
    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.


