namespace FoxitRDK
{
    public enum FSRotation
    {
        e_rotation0 = 0,
        e_rotation90 = 1,
        e_rotation180 = 2,
        e_rotation270 = 3,
        Unknown = 4
    }

    public enum FSProgressState
    {
        Error = 0,
        ToBeContinued = 1,
        Finished = 2
    }

    public enum FSDIBFormat
    {
        Invalid = 0,
        Rgb = 24,
        Rgb32 = 32,
        Argb = 544,
        e_dib8bppMask = 264
    }

    public enum FSBitmapInterpolationFlag
    {
        Downsample = 1,
        Quadratic = 2,
        Bicubic = 4
    }

    public enum FSErrorCode
    {
        Success = 0,
        File = 1,
        Format = 2,
        Password = 3,
        Handler = 4,
        Certificate = 5,
        Unknown = 6,
        InvalidLicense = 7,
        Param = 8,
        Unsupported = 9,
        OutOfMemory = 10,
        SecurityHandler = 11
    }

    public enum FSDisplayMode
    {
        UseNone = 0,
        UseOutlines = 1,
        UseThumbs = 2,
        FullScreen = 3,
        UseOC = 4,
        UseAttachment = 5
    }

    public enum FSZoomMode
    {
        Xyz = 1,
        FitPage = 2,
        FitHorz = 3,
        FitVert = 4,
        FitRect = 5,
        FitBBox = 6,
        FitBHorz = 7,
        FitBVert = 8
    }

    public enum FSModuleName
    {
        Standard = 0,
        Annotation = 1
    }

    public enum FSModuleRight
    {
        Unknown = -1,
        None = 0,
        Read = 1,
        Write = 2
    }

    public enum FSDefaultAPFlags
    {
        Font = 1,
        TextColor = 2,
        FontSize = 4
    }

    public enum FSFontStyles
    {
        FixedPitch = 1,
        Serif = 2,
        Symbolic = 4,
        Script = 8,
        NonSymbolic = 32,
        Italic = 64,
        AllCap = 65536,
        sSmallCap = 131072,
        sBold = 262144
    }

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

    public enum FSStandardFontID
    {
        Courier = 0,
        CourierB = 1,
        CourierBI = 2,
        CourierI = 3,
        Helvetica = 4,
        HelveticaB = 5,
        HelveticaBI = 6,
        HelveticaI = 7,
        Times = 8,
        TimesB = 9,
        TimesBI = 10,
        TimesI = 11,
        Symbol = 12,
        ZapfDingbats = 13
    }

    public enum FSPathPointType
    {
        MoveTo = 1,
        LineTo = 2,
        LineToCloseFigure = 3,
        BezierTo = 4,
        BezierToCloseFigure = 5
    }

    public enum FSFlattenOptions
    {
        All = 0,
        NoAnnot = 1,
        NoFormControl = 2
    }

    public enum FSPageBox
    {
        MediaBox = 0,
        CropBox = 1,
        TrimBox = 2,
        ArtBox = 3,
        BleedBox = 4
    }

    public enum FSAnnotStateModel
    {
        Marked = 1,
        Review = 2
    }

    public enum FSAnnotState
    {
        Marked = 1,
        Unmarked = 2,
        Accepted = 3,
        Rejected = 4,
        Cancelled = 5,
        Completed = 6,
        None = 7
    }

    public enum FSAnnotProperty
    {
        ModifiedDate = 0,
        CreationDate = 1,
        BorderColor = 2,
        FillColor = 3
    }

    public enum FSActionType
    {
        Unknown = 0,
        Goto = 1,
        GoToR = 2,
        GoToE = 3,
        Launch = 4,
        Thread = 5,
        Uri = 6,
        Sound = 7,
        Movie = 8,
        Hide = 9,
        Named = 10,
        SubmitForm = 11,
        ResetForm = 12,
        ImportData = 13,
        JavaScript = 14,
        SetOCGState = 15,
        Rendition = 16,
        Trans = 17,
        GoTo3DView = 18
    }

    public enum FSFDFDocType
    {
        Fdf = 0,
        Xfdf = 1
    }

    public enum FSRankMode
    {
        None,
        HitCountASC,
        HitCountDESC
    }

    public enum FSAnnotType
    {
        UnknownType = 0,
        Note = 1,
        Link = 2,
        FreeText = 3,
        Line = 4,
        Square = 5,
        Circle = 6,
        Polygon = 7,
        PolyLine = 8,
        Highlight = 9,
        Underline = 10,
        Squiggly = 11,
        StrikeOut = 12,
        Stamp = 13,
        Caret = 14,
        Ink = 15,
        PSInk = 16,
        FileAttachment = 17,
        Sound = 18,
        Movie = 19,
        Widget = 20,
        Screen = 21,
        PrinterMark = 22,
        TrapNet = 23,
        Watermark = 24,
        e_annot3D = 25,
        Popup = 26
    }

    public enum FSAnnotFlags
    {
        Invisible = 1,
        Hidden = 2,
        Print = 4,
        NoZoom = 8,
        NoRotate = 16,
        NoView = 32,
        ReadOnly = 64,
        Locked = 128,
        ToggleNoView = 256,
        LockedContents = 512
    }

    public enum FSBorderStyle
    {
        Solid = 0,
        Dashed = 1,
        UnderLine = 2,
        Beveled = 3,
        Inset = 4,
        Cloudy = 5
    }

    public enum FSHighlightingMode
    {
        None = 0,
        Invert = 1,
        Outline = 2,
        Push = 3,
        Toggle = 4
    }

    public enum FSEncryptType
    {
        Unknown = -1,
        None = 0,
        Password = 1,
        Certificate = 2,
        FoxitDRM = 3,
        Custom = 4,
        Rms = 5
    }

    public enum FSCipherType
    {
        None = 0,
        Rc4 = 1,
        Aes = 2
    }

    public enum FSGraphicsObjectType
    {
        All = 0,
        Text = 1,
        Path = 2,
        Image = 3,
        Shading = 4,
        FormXObject = 5
    }

    public enum FSFillMode
    {
        None = 0,
        Alternate = 1,
        Winding = 2
    }

    public enum FSRenderBlendMode
    {
        Normal = 0,
        Multiply = 1,
        Screen = 2,
        Overlay = 3,
        Darken = 4,
        Lighten = 5,
        ColorDodge = 6,
        ColorBurn = 7,
        Hardlight = 8,
        Softlight = 9,
        Difference = 10,
        Exclusion = 11,
        Hue = 21,
        Saturation = 22,
        Color = 23,
        Luminosity = 24
    }

    public enum FSLineJoinType
    {
        Miter = 0,
        Round = 1,
        Bevel = 2
    }

    public enum FSLineCapType
    {
        Butt = 0,
        Round = 1,
        Square = 2
    }

    public enum FSTextMode
    {
        Fill = 0,
        Stroke = 1,
        FillStroke = 2,
        Invisible = 3,
        FillClip = 4,
        StrokeClip = 5,
        FillStrokeClip = 6,
        Clip = 7
    }

    public enum FSImageColorSpace
    {
        Invalid = 0,
        DeviceGray = 1,
        DeviceRGB = 2,
        DeviceCMYK = 3,
        CalGray = 4,
        CalRGB = 5,
        Lab = 6,
        Separation = 8,
        DeviceN = 9,
        Pattern = 11,
        ICCBasedDeviceGray = 12,
        ICCBasedDeviceRGB = 13,
        ICCBasedDeviceCMYK = 14
    }

    public enum FSPageLabelStyle
    {
        None = 0,
        DecimalNums = 1,
        UpperRomanNums = 2,
        LowerRomanNums = 3,
        UpperLetters = 4,
        LowerLetters = 5
    }

    public enum FSPasswordType
    {
        Invalid = 0,
        NoPassword = 1,
        User = 2,
        Owner = 3
    }

    public enum FSUserPermissions
    {
        Print = 4,
        Modify = 8,
        Extract = 16,
        AnnotForm = 32,
        FillForm = 256,
        ExtractAccess = 512,
        Assemble = 1024,
        PrintHigh = 2048
    }

    public enum FSSaveFlags
    {
        Normal = 0,
        Incremental = 1,
        NoOriginal = 2,
        ObjectStream = 4
    }

    public enum FSImportFlags
    {
        Normal = 0,
        WithLayers = 1,
        ShareStream = 2
    }

    public enum FSPageParseFlag
    {
        PageNormal = 0,
        PageTextOnly = 1,
        TextOutputHyphen = 2
    }

    public enum FSCalcMarginMode
    {
        ContentsBox = 0,
        Detection = 1
    }

    public enum FSBookmarkStyle
    {
        Normal = 0,
        Italic = 1,
        Bold = 2
    }

    public enum FSBookmarkPosition
    {
        FirstChild = 0,
        LastChild = 1,
        PrevSibling = 2,
        NextSibling = 3,
        FirstSibling = 4,
        LastSibling = 5
    }

    public enum FSNameTreeType
    {
        Dests = 1,
        JavaScript = 2,
        EmbeddedFiles = 3
    }

    public enum FSFormFieldType
    {
        UnknownType = 0,
        PushButton = 1,
        CheckBox = 2,
        RadioButton = 3,
        ComboBox = 4,
        ListBox = 5,
        TextField = 6,
        Signature = 7
    }

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

    public enum FSLayerUsageType
    {
        View = 0,
        Design = 1,
        Print = 2,
        Export = 3,
        Zoom = 4
    }

    public enum FSLayerUsageState
    {
        On = 0,
        Off = 1,
        Unchanged = 2,
        Undefined = 3
    }

    public enum FSRenderColorMode
    {
        Normal = 0,
        Mapping = 2
    }

    public enum FSRenderContentFlag
    {
        Page = 1,
        Annot = 2
    }

    public enum FSDeviceType
    {
        Printer = 0,
        Display = 1
    }

    public enum FSPDFObjectType
    {
        InvalidType = 0,
        Boolean = 1,
        Number = 2,
        String = 3,
        Name = 4,
        Array = 5,
        Dictionary = 6,
        Stream = 7,
        Null = 8,
        Reference = 9
    }

    public enum FSSearchFlag
    {
        Normal = 0,
        MatchCase = 1,
        MatchWholeWord = 2,
        Consecutive = 4
    }

    public enum FSSignatureStates
    {
        Unknown = 0,
        NoSignData = 512,
        Unsigned = 1,
        Signed = 2,
        VerifyValid = 4,
        VerifyInvalid = 8,
        VerifyErrorData = 16,
        VerifyNoSupportWay = 32,
        VerifyErrorByteRange = 64,
        VerifyChange = 128,
        VerifyIncredible = 256,
        VerifyIssueValid = 4096,
        VerifyIssueUnknown = 8192,
        VerifyIssueRevoke = 16384,
        VerifyIssueExpire = 32768,
        VerifyIssueUncheck = 65536,
        VerifyIssueCurrent = 131072,
        VerifyTimestampNone = 262144,
        VerifyTimestampDoc = 524288,
        VerifyTimestampValid = 1048576,
        VerifyTimestampInvalid = 2097152,
        VerifyTimestampExpire = 4194304,
        VerifyTimestampIssueUnknown = 8388608,
        VerifyTimestampIssueInvalid = 16777216,
        VerifyTimestampTimeBefore = 33554432
    }

    public enum FSSignatureAPFlags
    {
        FoxitFlag = 1,
        Label = 2,
        Reason = 4,
        SigningTime = 8,
        Dn = 16,
        Location = 32,
        Signer = 64,
        Bitmap = 128,
        Text = 256
    }

    public enum FSSignatureKeyName
    {
        Signer = 0,
        Location = 1,
        Reason = 2,
        ContactInfo = 3,
        Dn = 4,
        Text = 5,
        Filter = 6,
        SubFilter = 7
    }

    public enum FSDigestAlgorithm
    {
        e_digestSHA1 = 0,
        e_digestSHA256 = 1,
        e_digestSHA384 = 2,
        e_digestSHA512 = 3
    }

    public enum FSReflowFlags
    {
        Normal = 0,
        WithImage = 1,
        NoTruncate = 2
    }

    public enum FSLayoutMode
    {
        Unknown = 0,
        Continuous,
        Single,
        Two,
        Multiple,
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