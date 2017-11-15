/**
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
    //[Native]
    public enum FSRotation
    {
        e_rotation0 = 0,
        e_rotation90,
        e_rotation180,
        e_rotation270,
        Unknown
    }

    //[Native]
    public enum FSProgressState
    {
        Error = 0,
        ToBeContinued,
        Finished
    }

    //[Native]
    public enum FSDIBFormat
    {
        Invalid = 0,
        Rgb = 24,
        Rgb32 = 32,
        Argb = 544,
        e_dib8bppMask = 264,
        e_dib8bpp = 8
    }

    //[Native]
    public enum FSBitmapInterpolationFlag
    {
        Downsample = 1 << 0,
        Quadratic = 1 << 1,
        Bicubic = 1 << 2
    }

    //[Native]
    public enum FSErrorCode
    {
        Success = 0,
        File,
        Format,
        Password,
        Handler,
        Certificate,
        Unknown,
        InvalidLicense,
        Param,
        Unsupported,
        OutOfMemory,
        SecurityHandler,
        NotParsed,
        NotFound,
        InvalidType,
        Conflict,
        UnknownState,
        DataNotReady,
        InvalidData
    }

    //[Native]
    public enum FSDisplayMode
    {
        UseNone = 0,
        UseOutlines,
        UseThumbs,
        FullScreen,
        UseOC,
        UseAttachment
    }

    //[Native]
    public enum FSZoomMode
    {
        Xyz = 1,
        FitPage,
        FitHorz,
        FitVert,
        FitRect,
        FitBBox,
        FitBHorz,
        FitBVert
    }

    //[Native]
    public enum FSModuleName
    {
        Standard = 0,
        Annotation
    }

    //[Native]
    public enum FSModuleRight
    {
        Unknown = -1,
        None = 0,
        Read,
        Write
    }

    //[Native]
    public enum FSDefaultAPFlags
    {
        Font = 1 << 0,
        TextColor = 1 << 1,
        FontSize = 1 << 2
    }

    //[Native]
    public enum FSFontStyles
    {
        FixedPitch = 1 << 0,
        Serif = 1 << 1,
        Symbolic = 1 << 2,
        Script = 1 << 3,
        NonSymbolic = 1 << 5,
        Italic = 1 << 6,
        AllCap = 1 << 16,
        sSmallCap = 1 << 17,
        sBold = 1 << 18
    }

    //[Native]
    public enum FSFontCharset
    {
        Ansi = 0,
        Default = 1,
        Symbol = 2,
        Shift_JIS = 128,
        Hangeul = 129,
        Gb2312 = 134,
        ChineseBig5 = 136,
        Thai = 222,
        EastEurope = 238,
        Russian = 204,
        Greek = 161,
        Turkish = 162,
        Hebrew = 177,
        Arabic = 178,
        Baltic = 186
    }

    //[Native]
    public enum FSStandardFontID
    {
        Courier = 0,
        CourierB,
        CourierBI,
        CourierI,
        Helvetica,
        HelveticaB,
        HelveticaBI,
        HelveticaI,
        Times,
        TimesB,
        TimesBI,
        TimesI,
        Symbol,
        ZapfDingbats
    }

    //[Native]
    public enum FSPathPointType
    {
        MoveTo = 1,
        LineTo,
        LineToCloseFigure,
        BezierTo,
        BezierToCloseFigure
    }

    //[Native]
    public enum FSFlattenOptions
    {
        All = 0,
        NoAnnot = 1 << 0,
        NoFormControl = 1 << 1
    }

    //[Native]
    public enum FSUserPermissions
    {
        Print = 1 << 2,
        Modify = 1 << 3,
        Extract = 1 << 4,
        AnnotForm = 1 << 5,
        FillForm = 1 << 8,
        ExtractAccess = 1 << 9,
        Assemble = 1 << 10,
        PrintHigh = 1 << 11
    }

    //[Native]
    public enum FSPageBox
    {
        MediaBox = 0,
        CropBox,
        TrimBox,
        ArtBox,
        BleedBox
    }

    //[Native]
    public enum FSAnnotStateModel
    {
        Marked = 1,
        Review
    }

    //[Native]
    public enum FSAnnotState
    {
        Marked = 1,
        Unmarked,
        Accepted,
        Rejected,
        Cancelled,
        Completed,
        None = 7
    }

    //[Native]
    public enum FSAnnotProperty
    {
        ModifiedDate = 0,
        CreationDate,
        BorderColor,
        FillColor
    }

    //[Native]
    public enum FSProgressType
    {
        Parse,
        ImportPages,
        RenderPage,
        QuickRenderPage,
        ReflowRenderPage,
        RenderBitmap,
        SignatureSign,
        SignatureVerify,
        Save
    }

    //[Native]
    public enum FSType
    {
        e_TypeNormal = 0
    }

    public enum FSActionType
    {
        Unknown = 0,
        Goto,
        GoToR,
        GoToE,
        Launch,
        Thread,
        Uri,
        Sound,
        Movie,
        Hide,
        Named,
        SubmitForm,
        ResetForm,
        ImportData,
        JavaScript,
        SetOCGState,
        Rendition,
        Trans,
        GoTo3DView
    }

    //[Native]
    public enum FSNewWindowFlag
    {
        False = 0,
        True,
        None
    }

    //[Native]
    public enum FSFDFDocType
    {
        Fdf = 0,
        Xfdf = 1
    }

    //[Native]
    public enum FSRankMode
    {
        None,
        HitCountASC,
        HitCountDESC
    }

    //[Native]
    public enum FSAnnotType
    {
        UnknownType = 0,
        Note,
        Link,
        FreeText,
        Line,
        Square,
        Circle,
        Polygon,
        PolyLine,
        Highlight,
        Underline,
        Squiggly,
        StrikeOut,
        Stamp,
        Caret,
        Ink,
        PSInk,
        FileAttachment,
        Sound,
        Movie,
        Widget,
        Screen,
        PrinterMark,
        TrapNet,
        Watermark,
        e_annot3D,
        Popup
    }

    //[Native]
    public enum FSAnnotFlags
    {
        Invisible = 1 << 0,
        Hidden = 1 << 1,
        Print = 1 << 2,
        NoZoom = 1 << 3,
        NoRotate = 1 << 4,
        NoView = 1 << 5,
        ReadOnly = 1 << 6,
        Locked = 1 << 7,
        ToggleNoView = 1 << 8,
        LockedContents = 1 << 9
    }

    //[Native]
    public enum FSBorderStyle
    {
        Solid = 0,
        Dashed,
        UnderLine,
        Beveled,
        Inset,
        Cloudy
    }

    //[Native]
    public enum FSHighlightingMode
    {
        None = 0,
        Invert,
        Outline,
        Push,
        Toggle
    }

    //[Native]
    public enum FSAlignment
    {
        Left,
        Center,
        Right
    }

    //[Native]
    public enum FSAnnotMKEntry
    {
        Rotation = 0,
        BorderColor = 1,
        BackgroundColor = 2,
        NormalCaption = 3,
        RolloverCaption = 4,
        DownCaption = 5,
        NormalIcon = 6,
        RolloverIcon = 7,
        DownIcon = 8,
        IconFit = 9,
        IconCaptionRelation = 10
    }

    //[Native]
    public enum FSAnnotMKIconCaptionRelation
    {
        NoIcon = 0,
        NoCaption = 1,
        CaptionBelowIcon = 2,
        CaptionAboveIcon = 3,
        CaptionRight = 4,
        CaptionLeft = 5,
        CaptionOvrlayOnIcon = 6
    }

    //[Native]
    public enum FSIconScaleWayType
    {
        Always = 1,
        Bigger = 2,
        Smaller = 3,
        Never = 4
    }

    //[Native]
    public enum FSEncryptType
    {
        Unknown = -1,
        None = 0,
        Password,
        Certificate,
        FoxitDRM,
        Custom,
        Rms
    }

    //[Native]
    public enum FSCipherType
    {
        None = 0,
        Rc4,
        Aes
    }

    //[Native]
    public enum FSGraphicsObjectType
    {
        All = 0,
        Text,
        Path,
        Image,
        Shading,
        FormXObject
    }

    //[Native]
    public enum FSFillMode
    {
        None = 0,
        Alternate,
        Winding
    }

    //[Native]
    public enum FSRenderBlendMode
    {
        Normal = 0,
        Multiply,
        Screen,
        Overlay,
        Darken,
        Lighten,
        ColorDodge,
        ColorBurn,
        Hardlight,
        Softlight,
        Difference,
        Exclusion = 11,
        Hue = 21,
        Saturation = 22,
        Color = 23,
        Luminosity = 24
    }

    //[Native]
    public enum FSLineJoinType
    {
        Miter = 0,
        Round,
        Bevel
    }

    //[Native]
    public enum FSLineCapType
    {
        Butt = 0,
        Round,
        Square
    }

    //[Native]
    public enum FSTextMode
    {
        Fill = 0,
        Stroke,
        FillStroke,
        Invisible,
        FillClip,
        StrokeClip,
        FillStrokeClip,
        Clip
    }

    //[Native]
    public enum FSImageColorSpace
    {
        Invalid = 0,
        DeviceGray,
        DeviceRGB,
        DeviceCMYK,
        CalGray,
        CalRGB,
        Lab,
        Separation = 8,
        DeviceN = 9,
        Pattern = 11,
        ICCBasedDeviceGray = 12,
        ICCBasedDeviceRGB = 13,
        ICCBasedDeviceCMYK = 14
    }

    //[Native]
    public enum FSPageLabelStyle
    {
        None = 0,
        DecimalNums,
        UpperRomanNums,
        LowerRomanNums,
        UpperLetters,
        LowerLetters
    }

    //[Native]
    public enum FSPasswordType
    {
        Invalid = 0,
        NoPassword,
        User,
        Owner
    }

    //[Native]
    public enum FSSaveFlags
    {
        Normal = 0,
        Incremental = 1 << 0,
        NoOriginal = 1 << 1,
        XRefStream = 1 << 3,
        Linearized = 1 << 12
    }

    //[Native]
    public enum FSImportFlags
    {
        Normal = 0,
        WithLayers = 1 << 0,
        ShareStream = 1 << 1
    }

    //[Native]
    public enum FSPageParseFlag
    {
        PageNormal = 0,
        PageTextOnly = 1 << 0,
        TextOutputHyphen = 1 << 1
    }

    //[Native]
    public enum FSCalcMarginMode
    {
        ContentsBox = 0,
        Detection = 1
    }

    //[Native]
    public enum FSBookmarkStyle
    {
        Normal = 0,
        Italic = 1,
        Bold = 1 << 1
    }

    //[Native]
    public enum FSBookmarkPosition
    {
        FirstChild = 0,
        LastChild,
        PrevSibling,
        NextSibling,
        FirstSibling,
        LastSibling
    }

    //[Native]
    public enum FSNameTreeType
    {
        Dests = 1,
        JavaScript,
        EmbeddedFiles
    }

    //[Native]
    public enum FSMetadataKeyType
    {
        Standard = 1,
        Custom = 2
    }

    //[Native]
    public enum FSFormFieldType
    {
        UnknownType = 0,
        PushButton,
        CheckBox,
        RadioButton,
        ComboBox,
        ListBox,
        TextField,
        Signature
    }

    //[Native]
    public enum FSFormFieldFlags
    {
        Readonly = 1,
        Required = 2,
        NoExport = 4,
        ButtonNoToggleToOff = 256,
        ButtonRadiosInUnison = 512,
        TextMultiline = 256,
        TextPassword = 512,
        TextDoNotScroll = 1024,
        TextCombo = 2048,
        ComboEdit = 256,
        ChoiseMultiselect = 256
    }

    //[Native]
    public enum FSLayerUsageType
    {
        View = 0,
        Design,
        Print,
        Export,
        Zoom
    }

    //[Native]
    public enum FSLayerUsageState
    {
        On = 0,
        Off,
        Unchanged,
        Undefined
    }

    //[Native]
    public enum FSImageType
    {
        Unknown = -1,
        None = 0,
        Bmp = 1,
        Jpg = 2,
        Png = 3,
        Gif = 4,
        Tif = 5,
        Jpx = 6,
        Jbig2 = 8
    }

    //[Native]
    public enum FSRenderColorMode
    {
        Normal = 0,
        Mapping = 2
    }

    //[Native]
    public enum FSRenderContentFlag
    {
        Page = 1 << 0,
        Annot = 1 << 1
    }

    //[Native]
    public enum FSDeviceType
    {
        Printer = 0,
        Display = 1
    }

    //[Native]
    public enum FSPDFObjectType
    {
        InvalidType = 0,
        Boolean,
        Number,
        String,
        Name,
        Array,
        Dictionary,
        Stream,
        Null,
        Reference
    }

    //[Native]
    public enum FSSearchFlag
    {
        Normal = 0,
        MatchCase = 1 << 0,
        MatchWholeWord = 1 << 1,
        Consecutive = 1 << 2
    }

    //[Native]
    public enum FSSignatureStates
    {
        Unknown = 0,
        Unsigned = 1 << 0,
        Signed = 1 << 1,
        VerifyValid = 1 << 2,
        VerifyInvalid = 1 << 3,
        VerifyErrorData = 1 << 4,
        VerifyNoSupportWay = 1 << 5,
        VerifyErrorByteRange = 1 << 6,
        VerifyChange = 1 << 7,
        VerifyIncredible = 1 << 8,
        NoSignData = 1 << 9,
        VerifyIssueValid = 1 << 12,
        VerifyIssueUnknown = 1 << 13,
        VerifyIssueRevoke = 1 << 14,
        VerifyIssueExpire = 1 << 15,
        VerifyIssueUncheck = 1 << 16,
        VerifyIssueCurrent = 1 << 17,
        VerifyTimestampNone = 1 << 18,
        VerifyTimestampDoc = 1 << 19,
        VerifyTimestampValid = 1 << 20,
        VerifyTimestampInvalid = 1 << 21,
        VerifyTimestampExpire = 1 << 22,
        VerifyTimestampIssueUnknown = 1 << 23,
        VerifyTimestampIssueInvalid = 1 << 24,
        VerifyTimestampTimeBefore = 1 << 25
    }

    //[Native]
    public enum FSSignatureAPFlags
    {
        FoxitFlag = 1 << 0,
        Label = 1 << 1,
        Reason = 1 << 2,
        SigningTime = 1 << 3,
        Dn = 1 << 4,
        Location = 1 << 5,
        Signer = 1 << 6,
        Bitmap = 1 << 7,
        Text = 1 << 8
    }

    //[Native]
    public enum FSSignatureKeyName
    {
        Signer = 0,
        Location,
        Reason,
        ContactInfo,
        Dn,
        Text,
        Filter,
        SubFilter
    }

    //[Native]
    public enum FSDigestAlgorithm
    {
        e_digestSHA1 = 0,
        e_digestSHA256,
        e_digestSHA384,
        e_digestSHA512
    }

    //[Native]
    public enum FSReflowFlags
    {
        Normal = 0,
        WithImage = 1 << 0,
        NoTruncate = 1 << 1
    }

    //[Native]
    public enum FSWatermarkPosition
    {
        TopLeft = 0,
        TopCenter = 1,
        TopRight = 2,
        CenterLeft = 3,
        Center = 4,
        CenterRight = 5,
        BottomLeft = 6,
        BottomCenter = 7,
        BottomRight = 8
    }

    //[Native]
    public enum FSWatermarkFlags
    {
        ASPageContents = 0,
        ASAnnot = 1,
        OnTop = 2,
        NoPrint = 4,
        Invisible = 8
    }

    //[Native]
    public enum FSWatermarkFontStyle
    {
        Normal = 0,
        Underline = 1
    }

    //[Native]
    public enum FSWatermarkTextAlignment
    {
        Left = 0,
        Center = 1,
        Right = 2
    }

    public enum FSLayoutMode
    {
        Unknown = 0,
        Continuous,
        Single,
        Two,
        Reflow
    }

    public enum FSReflowMode
    {
        None = -1,
        Withimage = 0,
        Onlytext
    }

    public enum FSDisplayZoomMode
    {
        Unknown = 0,
        FitPage,
        Fitwidth,
        Fitheight
    }

    public enum FSCropMode
    {
        None = -1,
        Contentsbox,
        Detection,
        Customized
    }
}
