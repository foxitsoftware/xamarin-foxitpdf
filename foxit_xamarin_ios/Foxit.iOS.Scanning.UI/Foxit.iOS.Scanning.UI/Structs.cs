/**
* Copyright (C) 2003-2021, Foxit Software Inc..
* All Rights Reserved.
*
* http://www.foxitsoftware.com
*
* The following code is copyrighted and is the proprietary of Foxit Software Inc.. It is not allowed to
* distribute any parts of Foxit PDF SDK for iOS to third party or public without permission unless an agreement
* is signed between Foxit Software Inc. and customers to explicitly grant customers permissions.
* Review legal.txt for additional license and legal information.
*/

using System;
using ObjCRuntime;

namespace Foxit.iOS.Scanning.UI
{
	//[Native]
	public enum FSPDFScanToolbarType 
	{
		FSPDFScanToolbarTypeBottombar
	}

	//[Native]
	public enum PDFScanMenuViewType 
	{
		ThumbnailInsertBlankPagePop = 0,
		Extract,
		SaveAs
	}

	//[Native]
	public enum FSScanCameraControllerItemType 
	{
		FlashLight,
		SingleShooting,
		Photos,
		AutoDection,
		FormatPageSize
	}
}
