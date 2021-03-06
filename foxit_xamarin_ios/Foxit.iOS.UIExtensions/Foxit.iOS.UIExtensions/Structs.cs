/**
* Copyright (C) 2003-2020, Foxit Software Inc..
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

namespace Foxit.iOS.UIExtensions
{
	//[Native]
	public enum FSPanelType 
	{
		Annotation = 1,
		Attachment,
		Outline,
		ReadingBookmark,
		DigitalSignature
	}

	//[Native]
	public enum SettingItemType 
	{
		Single,
		Continuous,
		Doublepage,
		Coverpage,
		Thumbnail,
		Reflow,
		Croppage,
		Lockscreen,
		Brightness,
		Nightmode,
		Panzoom,
		Fitpage,
		Fitwidth,
		Rotate,
		Speech
	}

	//[Native]
	public enum FSToolbarType 
	{
		TopBar = 1,
		BottomBar
	}
}
