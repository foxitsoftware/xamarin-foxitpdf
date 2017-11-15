﻿/**
 * Copyright (C) 2003-2017, Foxit Software Inc..
 * All Rights Reserved.
 *
 * http://www.foxitsoftware.com
 *
 * The following code is copyrighted and is the proprietary of Foxit Software Inc.. It is not allowed to
 * distribute any parts of Foxit Mobile PDF SDK to third party or public without permission unless an agreement
 * is signed between Foxit Software Inc. and customers to explicitly grant customers permissions.
 * Review legal.txt for additional license and legal information.
 */

using System;
using ObjCRuntime;

namespace FoxitRDK
{
    [Native]
    public enum FSPanelType : long
    {
        Annotation = 0,
        Attachment,
        Outline,
        ReadingBookmark
    }

    [Native]
    public enum SettingItemType : long
    {
        Single,
        Continuous,
        Doublepage,
        Thumbnail,
        Reflow,
        Croppage,
        Lockscreen,
        Brightness,
        Nightmode
    }
}
