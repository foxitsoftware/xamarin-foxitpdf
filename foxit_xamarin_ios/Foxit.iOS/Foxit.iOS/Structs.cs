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

using ObjCRuntime;

namespace Foxit.iOS
{
	//[Native]
	public enum FSErrorCode : long
	{
		Success = 0,
		File = 1,
		Format = 2,
		Password = 3,
		Handle = 4,
		Certificate = 5,
		Unknown = 6,
		InvalidLicense = 7,
		Param = 8,
		Unsupported = 9,
		OutOfMemory = 10,
		SecurityHandler = 11,
		NotParsed = 12,
		NotFound = 13,
		InvalidType = 14,
		Conflict = 15,
		UnknownState = 16,
		DataNotReady = 17,
		InvalidData = 18,
		XFALoadError = 19,
		NotLoaded = 20,
		InvalidState = 21,
		NotCDRM = 22,
		CanNotConnectToServer = 23,
		InvalidUserToken = 24,
		NoRights = 25,
		RightsExpired = 26,
		DeviceLimitation = 27,
		CanNotRemoveSecurityFromServer = 28,
		CanNotGetACL = 29,
		CanNotSetACL = 30,
		IsAlreadyCPDF = 31,
		IsAlreadyCDRM = 32,
		CanNotUploadDocInfo = 33,
		CanNotUploadCDRMInfo = 34,
		InvalidWrapper = 35,
		CanNotGetClientID = 36,
		CanNotGetUserToken = 37,
		InvalidACL = 38,
		InvalidClientID = 39,
		OCREngineNotInit = 40,
		DiskFull = 41,
		OCRTrialIsEnd = 42,
		FilePathNotExist = 43,
		ComplianceEngineNotInit = 44,
		ComplianceEngineInvalidUnlockCode = 45,
		ComplianceEngineInitFailed = 46,
		TimeStampServerMgrNotInit = 47,
		LTVVerifyModeNotSet = 48,
		LTVRevocationCallbackNotSet = 49,
		LTVCannotSwitchVersion = 50,
		LTVCannotCheckDTS = 51,
		LTVCannotLoadDSS = 52,
		LTVCannotLoadDTS = 53,
		NeedSigned = 54,
		ComplianceResourceFile = 55,
		TimeStampServerMgrNoDefaltServer = 56,
		DefaultTimeStampServer = 57,
		NoConnectedPDFModuleRight = 58,
		NoXFAModuleRight = 59,
		NoRedactionModuleRight = 60,
		NoRMSModuleRight = 61,
		NoOCRModuleRight = 62,
		NoComparisonModuleRight = 63,
		NoComplianceModuleRight = 64,
		NoOptimizerModuleRight = 65,
		NoConversionModuleRight = 66,
		OfficeComNotInit = 67,
		NoMicroOfficeInstalled = 68,
		ExcelHasNoContent = 69,
		NoLayoutRecognitionModuleRight = 70,
		WPSEngineNotFound = 71,
		LibreofficeEngineNotFound = 72,
		NoAccessibilityModuleRight = 73,
		ODAEngineNotFound = 74,
		NoTableMakerModuleRight = 75,
		NoDWG2PDFModuleRight = 76,
		NoAdvEditModuleRight = 77,
		NoPDF2OfficeModuleRight = 78,
		URLInBlackList = 79,
		OFDEngineNotInit = 80,
		NoOFDModuleRight = 81,
		No3DModuleRight = 82,
		InvalidRegex = 83,
		NoDocumentPermission = 84,
		NoOffice2PDFModuleRight = 85,
		MIPUPEEngineInitFailed = 86,
		MIPProtectionEngineInitFailed = 87,
		MIPCreateProtectionHandlerFailed = 88,
		MIPGetExtendedLabelInfoByIdFailed = 89,
		NoPrint2PDFModuleRight = 90
	}

	//[Native]
	public enum FSRotation : long
	{
		FSRotation0 = 0,
		FSRotation90 = 1,
		FSRotation180 = 2,
		FSRotation270 = 3,
		Unknown = 4
	}

	//[Native]
	public enum FSRotationPointOptions : long
	{
		Center = 0,
		LeftTop = 1,
		RightTop = 2,
		LeftBottom = 3,
		RightBottom = 4
	}

	//[Native]
	public enum FSAlignment : long
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	//[Native]
	public enum FSFillMode : long
	{
		None = 0,
		Alternate = 1,
		Winding = 2
	}

	//[Native]
	public enum FSPosition : long
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
	public enum FSModuleName : long
	{
		ConnectedPDF = 1,
		Xfa = 2,
		Redaction = 3,
		Rms = 4,
		Ocr = 5,
		Comparison = 6,
		Compliance = 7,
		Optimizer = 8,
		Conversion = 9,
		LayoutRecognition = 10,
		Accessibility = 11,
		TableMaker = 12,
		Dwg2pdf = 13,
		AdvEdit = 14,
		PDF2Office = 15,
		FSModuleName3D = 16,
		Ofd = 17,
		Office2PDF = 18,
		Print2PDF = 19
	}

	//[Native]
	public enum FSColorSpaceType : long
	{
		Invalid = 0,
		DeviceGray = 1,
		DeviceRGB = 2,
		DeviceCMYK = 3,
		CalGray = 4,
		CalRGB = 5,
		Lab = 6,
		ICCBased = 7,
		Separation = 8,
		DeviceN = 9,
		Indexed = 10,
		Pattern = 11,
		ICCBasedDeviceGray = 12,
		ICCBasedDeviceRGB = 13,
		ICCBasedDeviceCMYK = 14
	}

	//[Native]
	public enum FSLocaleID : long
	{
		Unspecified = 0,
		HongKong = 1,
		Taiwan = 2,
		Netherlands = 3,
		France = 4,
		Germany = 5,
		Italy = 6,
		Korea = 7,
		Japan = 8
	}

	//[Native]
	public enum FSFileFormatType : long
	{
		Fdf = 0,
		Xfdf = 1,
		Html = 2,
		Xdp = 3,
		Xml = 4,
		Xfd = 5,
		Pdf = 6,
		Txt = 7
	}

	//[Native]
	public enum FSProgressiveState : long
	{
		Error = 0,
		ToBeContinued = 1,
		Finished = 2
	}

	//[Native]
	public enum FSGraphStateLineCapStyle : long
	{
		Butt = 0,
		Round = 1,
		Square = 2
	}

	//[Native]
	public enum FSGraphStateLineJoinStyle : long
	{
		Miter = 0,
		Round = 1,
		Bevel = 2
	}

	//[Native]
	public enum FSRangeFilter : long
	{
		All = 0,
		Even = 1,
		Odd = 2
	}

	//[Native]
	public enum FSFontStyles : long
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

	//[Native]
	public enum FSFontCharset : long
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
	public enum FSFontCIDCharset : long
	{
		Unknown = 0,
		Gb1 = 1,
		Cns1 = 2,
		Japan1 = 3,
		Korea1 = 4,
		Unicode = 5
	}

	//[Native]
	public enum FSFontStandardID : long
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

	//[Native]
	public enum FSFontFontTypes : long
	{
		Type1 = 1,
		TrueType = 2,
		Type3 = 3,
		CIDFont = 4
	}

	//[Native]
	public enum FSPathPointType : long
	{
		MoveTo = 1,
		LineTo = 2,
		LineToCloseFigure = 3,
		BezierTo = 4,
		BezierToCloseFigure = 5
	}

	//[Native]
	public enum FSColorSpaceRenderingIntent : long
	{
		Perceptual = 0,
		RelColorimetric = 1,
		Saturation = 2,
		AbsColorimetric = 3
	}

	//[Native]
	public enum FSBitmapDIBFormat : long
	{
		Invalid = 0,
		FSBitmapDIB1bpp = 1,
		Rgb = 24,
		Rgb32 = 32,
		Argb = 544,
		Cmyk = 1056,
		FSBitmapDIB8bppMask = 264,
		FSBitmapDIB8bpp = 8,
		FSBitmapDIB8bppGray = 4104,
		Abgr = 546,
		Rgb565 = 1381
	}

	//[Native]
	public enum FSBitmapInterpolationFlag : long
	{
		Downsample = 1,
		Quadratic = 2,
		Bicubic = 4
	}

	//[Native]
	public enum FSBitmapFadeOutEnhancementAlgorithm : long
	{
		FSBitmapEnhanceAlgoGrayLevelTransformation = 0
	}

	//[Native]
	public enum FSBitmapFadeOutThresholdAlogrithm : long
	{
		FixedThreshold = 0,
		Otsu = 1
	}

	//[Native]
	public enum FSImageType : long
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
	public enum FSImageOrientation : long
	{
		None = 0,
		Normal = 1,
		FlipH = 2,
		Rotate180 = 3,
		FlipV = 4,
		Rotate90FlipH = 5,
		Rotate90 = 6,
		Rotate270FlipH = 7,
		Rotate270 = 8
	}

	//[Native]
	public enum FSPrintDeviceSettingDataOrientationFlag : long
	{
		Portrait = 0,
		Landscape = 1
	}

	//[Native]
	public enum FSRendererColorMode : long
	{
		Normal = 0,
		MappingGray = 1,
		Mapping = 2
	}

	//[Native]
	public enum FSRendererContentFlag : long
	{
		Page = 1,
		Annot = 2
	}

	//[Native]
	public enum FSRendererDeviceType : long
	{
		Display = 1,
		Printer = 2
	}

	//[Native]
	public enum FSBarcodeFormat : long
	{
		Code39 = 0,
		Code128 = 1,
		Ean8 = 2,
		Upca = 3,
		Ean13 = 4,
		Itf = 5,
		Pdf417 = 6,
		QRCode = 7
	}

	//[Native]
	public enum FSBarcodeQRErrorCorrectionLevel : long
	{
		Low = 0,
		Medium = 1,
		Quater = 2,
		High = 3
	}

	//[Native]
	public enum FSAppProviderCallbackAppInfo : long
	{
		Version = 0,
		Language = 1,
		Platform = 2,
		Variation = 3,
		Name = 4,
		Type = 5
	}

	//[Native]
	public enum FSAppProviderCallbackBeepType : long
	{
		Error = 0,
		Warning = 1,
		Question = 2,
		Status = 3,
		Default = 4
	}

	//[Native]
	public enum FSAppProviderCallbackStringID : long
	{
		ValidateFailed = 1,
		CalcOverride = 2,
		ModifyField = 3,
		NotModifyField = 4,
		AppName = 5,
		ImageFilter = 6,
		UnknownCaught = 7,
		UnableToSet = 8,
		ValueExcalmatory = 9,
		InvalidEnumValue = 10,
		UnsupportMethod = 11,
		UnsupportProperty = 12,
		InvalidPropertySetOperation = 13,
		NotDefaultValue = 14,
		UnableSetLanguage = 15,
		UnableSetNumPages = 16,
		UnableSetPlatformValue = 17,
		UnableSetValidationsEnabledValue = 18,
		UnableSetValidationsValue = 19,
		UnableSetVersion = 20,
		UnableSetReady = 21,
		NumberOfOccur = 22,
		UnableSetClassName = 23,
		UnableSetLengthValue = 24,
		UnsupportChar = 25,
		BadSuffix = 26,
		ExpectedIdent = 27,
		ExpectedString = 28,
		InvalidateChar = 29,
		Redefinition = 30,
		InvalidToken = 31,
		InvalidExpression = 32,
		UndefineIdentifier = 33,
		InvalidateLeftValue = 34,
		CompilerError = 35,
		CannotModifyValue = 36,
		ParametersError = 37,
		ExpectedEndIf = 38,
		UnexpectedExpression = 39,
		ConditionIsNull = 40,
		IllegalBreak = 41,
		IllegalContinue = 42,
		ExpectedOperator = 43,
		DivideZero = 44,
		CannotCovertToObject = 45,
		NotFoundContainer = 46,
		NotFoundProperty = 47,
		NotFoundMethod = 48,
		NotFoundConst = 49,
		NotAssignObject = 50,
		InvalidateInstruction = 51,
		ExpectedNumber = 52,
		ValidateOutOfArray = 53,
		CannotAssign = 54,
		NotFoundFunction = 55,
		IsNotArray = 56,
		OutOfArrayRange = 57,
		NotSupportArrayCalculate = 58,
		ArgumentNotArray = 59,
		ArgumentExpectContainer = 60,
		AccessProertyInNotObject = 61,
		FunctionBuildIn = 62,
		ErrorMessage = 63,
		IndexValueOutOfBounds = 64,
		IncorrectNumberOfMethod = 65,
		ArgumentMismatch = 66,
		InvalidEnumerate = 67,
		InvalidAppend = 68,
		SOMExpectedList = 69,
		NotHaveProperty = 70,
		InvalidNodeType = 71,
		ViolateBoundary = 72,
		ServerDeny = 73,
		WeekDaySun = 74,
		WeekDayMon = 75,
		WeekDayTue = 76,
		WeekDayWed = 77,
		WeekDayThu = 78,
		WeekDayFri = 79,
		WeekDaySat = 80,
		MonthJan = 81,
		MonthFeb = 82,
		MonthMarch = 83,
		MonthApril = 84,
		MonthMay = 85,
		MonthJune = 86,
		MonthJuly = 87,
		MonthAug = 88,
		MonthSep = 89,
		MonthOct = 90,
		MonthNov = 91,
		MonthDec = 92,
		Today = 93,
		ValidateLimit = 94,
		ValidateNullWarning = 95,
		ValidateNullError = 96,
		ValidateWarning = 97,
		ValidateError = 98,
		ValidateNumberError = 99,
		ScriptFailedError = 100,
		ScriptInvalidValue = 101,
		SubmitValidateNullError = 102,
		InvalidBarcodeValue = 103,
		ScriptArgumentMismatch = 104
	}

	//[Native]
	public enum FSAppProviderCallbackMsgBoxIconType : long
	{
		Error = 0,
		Warning = 1,
		Question = 2,
		Status = 3
	}

	//[Native]
	public enum FSAppProviderCallbackMsgBoxButtonType : long
	{
		Ok = 0,
		OKCancel = 1,
		YesNo = 2,
		YesNoCancel = 3
	}

	//[Native]
	public enum FSAppProviderCallbackMsgBoxButtonID : long
	{
		Ok = 1,
		Cancel = 2,
		No = 3,
		Yes = 4
	}

	//[Native]
	public enum FSDocProviderCallbackInvalidateFlag : long
	{
		AllPages = 0,
		CurrentPage = 1
	}

	//[Native]
	public enum FSDocProviderCallbackPrintOption : long
	{
		ShowDialog = 1,
		CanCancel = 2,
		ShrinkPage = 4,
		AsImage = 8,
		ReverseOrder = 16,
		PrintAnnot = 32
	}

	//[Native]
	public enum FSDocProviderCallbackSubmitFormat : long
	{
		Xdp = 0,
		Pdf = 1,
		UrlEncoded = 2,
		Xfd = 3,
		Xml = 4
	}

	//[Native]
	public enum FSDocProviderCallbackTextEncoding : long
	{
		None = 0,
		Big5 = 1,
		FontSpecific = 2,
		Gbk = 3,
		Gb18030 = 4,
		Gb2312 = 5,
		Iso8859nn = 6,
		Ksc5601 = 7,
		ShiftJIS = 8,
		Ucs2 = 9,
		Utf16 = 10,
		Utf8 = 11
	}

	//[Native]
	public enum FSDocProviderCallbackPageViewEventType : long
	{
		Added = 0,
		Removed = 1,
		AllRemoved = 2
	}

	//[Native]
	public enum FSDocProviderCallbackWidgetEventType : long
	{
		Added = 0,
		BeforeRemoved = 1
	}

	//[Native]
	public enum FSXFADocEventType : long
	{
		Unknown = 0,
		PostPrint = 1,
		PrePrint = 2
	}

	//[Native]
	public enum FSXFADocType : long
	{
		Dynamic = 0,
		Static = 1,
		Xdp = 2
	}

	//[Native]
	public enum FSXFADocExportDataType : long
	{
		Xml = 0,
		StaticXDP = 1,
		Xdp = 2
	}

	//[Native]
	public enum FSXFAWidgetHitTestArea : long
	{
		Unknown = 0,
		Client = 1,
		TitleBar = 2,
		HyperLink = 3
	}

	//[Native]
	public enum FSXFAWidgetWidgetType : long
	{
		Barcode = 0,
		PushButton = 1,
		CheckButton = 2,
		Arc = 3,
		DateTimeEdit = 4,
		NumericEdit = 5,
		Signature = 6,
		ChoiceList = 7,
		ImageEdit = 8,
		Line = 9,
		PasswordEdit = 10,
		RadioButton = 11,
		Rectangle = 12,
		TextEdit = 13,
		Unknown = 14,
		ExclGroup = 15,
		Image = 16
	}

	//[Native]
	public enum FSXFAWidgetPresenceProperty : long
	{
		Unknown = 0,
		Visible = 1,
		Hidden = 2,
		Inactive = 3,
		Invisible = 4
	}

	//[Native]
	public enum FSXFAWidgetWidgetNameType : long
	{
		Field = 0,
		Caption = 1,
		FullName = 2
	}

	//[Native]
	public enum FSXFAWidgetWidgetHAlignType : long
	{
		Center = 128,
		Justify = 156,
		JustifyAll = 61,
		Left = 252,
		Radix = 231,
		Right = 54
	}

	//[Native]
	public enum FSXFAWidgetWidgetVAlignType : long
	{
		Top = 33,
		Bottom = 85,
		Middle = 161
	}

	//[Native]
	public enum FSXFAWidgetWidgetEdgePosition : long
	{
		Top = 0,
		Right = 1,
		Bottom = 2,
		Left = 3
	}

	//[Native]
	public enum FSCompareResultInfoCompareResultType : long
	{
		None = -1,
		DeleteText = 0,
		InsertText = 1,
		ReplaceText = 2,
		DeleteImage = 6,
		InsertImage = 7,
		ReplaceImage = 8,
		DeletePath = 9,
		InsertPath = 10,
		ReplacePath = 11,
		DeleteShading = 12,
		InsertShading = 13,
		ReplaceShading = 14,
		DeleteAnnot = 15,
		InsertAnnot = 16,
		ReplaceAnnot = 17,
		TextAttriChange = 18
	}

	//[Native]
	public enum FSComparisonCompareType : long
	{
		All = 0,
		Text = 1,
		Annotation = 2
	}

	//[Native]
	public enum FSImageSettingsImageCompressMode : long
	{
		High = 10003,
		jpeg = 10005,
		jpeg2000 = 10006,
		Retain = 10007
	}

	//[Native]
	public enum FSImageSettingsImageCompressQuality : long
	{
		Minimum = 1,
		Low = 2,
		Medium = 3,
		High = 4,
		Maximum = 5
	}

	//[Native]
	public enum FSImageSettingsStretchMode : long
	{
		Default = -1,
		Off = 0,
		Interpol = 32,
		Downsample = 4,
		Bicubic = 128,
		NoSmooth = 256
	}

	//[Native]
	public enum FSMonoImageSettingsMonoImageCompressMode : long
	{
		Ccitt3 = 10001,
		Ccitt4 = 10002,
		High = 10003,
		jbig2 = 10004,
		Retain = 10007,
		RunLength = 10008
	}

	//[Native]
	public enum FSMonoImageSettingsMonoImageCompressQuality : long
	{
		less = 1,
		y = 2
	}

	//[Native]
	public enum FSMonoImageSettingsStretchMode : long
	{
		Default = -1,
		Off = 0,
		Interpol = 32,
		Downsample = 4,
		Bicubic = 128,
		NoSmooth = 256
	}

	//[Native]
	public enum FSOptimizerSettingsOptimizerOptions : long
	{
		CompressImages = 1,
		CleanUp = 2,
		DiscardObjects = 4,
		UnembeddedFonts = 8,
		DiscardUserData = 16
	}

	//[Native]
	public enum FSOptimizerSettingsCleanUpOptions : long
	{
		UseFlateForNonEncodedStream = 1,
		UseFlateInsteadOfLZW = 2,
		RemoveInvalidBookmarks = 4,
		RemoveInvalidLinks = 8
	}

	//[Native]
	public enum FSOptimizerSettingsDiscardObjectsOptions : long
	{
		FormActions = 1,
		FlattenFormFields = 2,
		JavaScriptActions = 4,
		EmbeddedPageThumbnails = 8,
		EmbeddedPrintSettings = 16,
		Bookmarks = 32,
		AlternateImages = 64,
		DocumentTags = 128,
		EmbeddedSearchIndex = 256
	}

	//[Native]
	public enum FSOptimizerSettingsDiscardUserDataOptions : long
	{
		AllAnnotsFormsAndMultimedia = 1,
		ExternalCrossReferences = 2,
		DocumentInfoAndMetaData = 4,
		FileAttchments = 8,
		PrivateDataOfOtherApp = 16,
		Layer = 32
	}

	//[Native]
	public enum FSHTML2PDFSettingDataHTML2PDFPageMode : long
	{
		SinglePage = 0,
		MultiplePage = 1
	}

	//[Native]
	public enum FSHTML2PDFSettingDataHTML2PDFScalingMode : long
	{
		None = 0,
		Scale = 1,
		Enlarge = 2
	}

	//[Native]
	public enum FSHTML2PDFSettingDataHTML2PDFEncodingFormat : long
	{
		Default = 0,
		Ascii = 1,
		Latin2 = 2,
		Latin3 = 3,
		Latin4 = 4,
		Latin5 = 5,
		Latin6 = 6,
		Iso88595 = 7,
		Arabic = 8,
		Greek = 9,
		Hebrew = 10,
		EucJp = 11,
		Sjs = 12,
		Jis = 13,
		Big5 = 14,
		Gb = 15,
		EucCn = 16,
		Ksc = 17,
		Unicode = 18,
		Euc = 19,
		Cns = 20,
		Big5Cp950 = 21,
		ASCII_7_bit = 22,
		Koi8r = 23,
		Cp852 = 24,
		Cp866 = 25,
		Cp874 = 26,
		Cp932 = 27,
		Cp1250 = 28,
		Cp1251 = 29,
		Cp1252 = 30,
		Cp1253 = 31,
		Cp1254 = 32,
		Cp1255 = 33,
		Cp1256 = 34,
		Cp1257 = 35,
		Koi8u = 36,
		Iso885915 = 37,
		Iso885911 = 38,
		Iso88598I = 39,
		Visual = 40,
		Csn369103 = 41,
		Iso885913 = 42,
		Iso2022Kr = 43,
		Gbk = 44,
		Gb18030 = 45,
		Big5Hkscs = 46,
		Iso2022Cn = 47,
		Tscii = 48,
		Tam = 49,
		Tab = 50,
		Jagran = 51,
		Macintosh = 52,
		Utf7 = 53,
		Bhaskar = 54,
		Htchanakya = 55,
		Utf16be = 56,
		Utf16le = 57,
		Utf32be = 58,
		Utf32le = 59,
		XBinaryenc = 60,
		HzGb2312 = 61,
		XUtf8utf8 = 62,
		XTamElango = 63,
		XTamLttmbarani = 64,
		XTamShree = 65,
		XTamTboomis = 66,
		XTamTmnews = 67,
		XTamWebtamil = 68,
		X_KDDI_Shift_JIS = 69,
		X_DoCoMo_Shift_JIS = 70,
		X_SoftBank_Shift_JIS = 71,
		XKddiIso2022Jp = 72,
		X_SoftBank_ISO_2022_JP = 73
	}

	//[Native]
	public enum FSHTML2PDFSettingDataHTML2PDFMediaStyle : long
	{
		Screen = 0,
		Print = 1
	}

	//[Native]
	public enum FSDWG2PDFSettingDataDWG2PDFExportFlags : long
	{
		EmbededTTF = 1,
		TTFTextAsGeometry = 2,
		SHXTextAsGeometry = 4,
		SimpleGeomOptimization = 8,
		EnableLayers = 16,
		IncludeOffLayers = 32,
		EmbededOptimizedTTF = 64,
		UseHLR = 128,
		FlateCompression = 256,
		ASCIIHexEncoding = 512,
		ExportHyperlinks = 1024,
		ZoomToExtentsMode = 2048,
		Linearized = 4096,
		Measuring = 16384
	}

	//[Native]
	public enum FSDWG2PDFSettingDataDWG2PDFExportHatchesType : long
	{
		Bitmap = 0,
		Drawing = 1,
		PdfPaths = 2,
		Polygons = 3
	}

	//[Native]
	public enum FSDWG2PDFSettingDataDWG2PDFSearchableTextType : long
	{
		NoSearch = 0,
		Shx = 1,
		Ttf = 2
	}

	//[Native]
	public enum FSDWG2PDFSettingDataDWG2PDFColorPolicy : long
	{
		NoPolicy = 0,
		Mono = 1,
		Grayscale = 2
	}

	//[Native]
	public enum FSFDFDocType : long
	{
		Fdf = 0,
		Xfdf = 1
	}

	//[Native]
	public enum FSPrintParamsPrintContent : long
	{
		Document = 0,
		DocAndAnnots = 1,
		FormFieldsOnly = 2
	}

	//[Native]
	public enum FSPrintParamsDuplexType : long
	{
		Simplex = 0,
		DuplexFlipLongEdge = 1,
		DuplexFlipShortEdge = 2
	}

	//[Native]
	public enum FSPrintParamsBookletDuplexMode : long
	{
		BothSides = 0,
		FrontSideOnly = 1,
		BackSideOnly = 2
	}

	//[Native]
	public enum FSPrintParamsBookletBinding : long
	{
		Right = 0,
		Left = 1,
		LeftTall = 2,
		RightTall = 3
	}

	//[Native]
	public enum FSPrintParamsPageOrder : long
	{
		Horizontal = 0,
		HorizontalReversed = 1,
		Vertical = 2
	}

	//[Native]
	public enum FSPrintParamsPrintHandling : long
	{
		None = 0,
		FitPaper = 1,
		ReducePaper = 2,
		MultiplePages = 3,
		TileLargePages = 4,
		Booklet = 5
	}

	//[Native]
	public enum FSFloatingInfoWindowPosition : long
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
	public enum FSFloatingInfoRelativeTarget : long
	{
		PageWindow = 0,
		AppWindow = 1,
		Desktop = 2,
		Monitor = 3
	}

	//[Native]
	public enum FSFloatingInfoResizeType : long
	{
		No = 0,
		KeepRatio = 1,
		Yes = 2
	}

	//[Native]
	public enum FSFloatingInfoOffScreenAction : long
	{
		Allow = 0,
		ForceOnScreen = 1,
		Cancel = 2
	}

	//[Native]
	public enum FSMediaSettingsPlayerWindowType : long
	{
		DockedPage = 1,
		Floating = 2,
		FullScreen = 4
	}

	//[Native]
	public enum FSSearchOptionWordMatching : long
	{
		Phrase = 0,
		AllWords = 1,
		AnyWord = 2
	}

	//[Native]
	public enum FSMediaPlayerCallbackJSMediaPlayerState : long
	{
		Open = 0,
		Close = 1,
		Playing = 2,
		Stop = 3,
		Suspend = 4
	}

	//[Native]
	public enum FSActionCallbackLanguage : long
	{
		Unknown = 0,
		Chs = 1,
		Cht = 2,
		Dan = 3,
		Deu = 4,
		Enu = 5,
		Esp = 6,
		Fra = 7,
		Ita = 8,
		Kor = 9,
		Jpn = 10,
		Nld = 11,
		Nor = 12,
		Ptb = 13,
		Suo = 14,
		Sve = 15
	}

	//[Native]
	public enum FSActionCallbackAppInfoType : long
	{
		FormsVersion = 0,
		ViewerType = 1,
		ViewerVariation = 2,
		ViewerVersion = 3,
		AppVersion = 4
	}

	//[Native]
	public enum FSActionCallbackMailType : long
	{
		Doc = 0,
		Form = 1,
		Msg = 2
	}

	//[Native]
	public enum FSActionCallbackJSFieldValueChangeType : long
	{
		Format = 0,
		Calculation = 1,
		SetValue = 2,
		SetReadOnly = 3,
		FillColor = 4
	}

	//[Native]
	public enum FSActionCallbackJSMediaPlayerState : long
	{
		Open = 0,
		Close = 1,
		Playing = 2,
		Stop = 3,
		Suspend = 4
	}

	//[Native]
	public enum FSActionCallbackLayoutMode : long
	{
		SinglePage = 0,
		Continuous = 1,
		Facing = 2,
		ContinuousFacing = 3
	}

	//[Native]
	public enum FSActionCallbackJsMailResult : long
	{
		Failed = 0,
		Success = 1,
		UserAbort = 2
	}

	//[Native]
	public enum FSActionCallbackSearchScope : long
	{
		ActiveDoc = 0,
		Folder = 1,
		Index = 2,
		ActiveIndexes = 3
	}

	//[Native]
	public enum FSFullTextSearchRankMode : long
	{
		None = 0,
		HitCountASC = 1,
		HitCountDESC = 2
	}

	//[Native]
	public enum FSPDFNameTreeType : long
	{
		Dests = 1,
		JavaScript = 2,
		EmbeddedFiles = 3,
		Pages = 4,
		Templates = 5
	}

	//[Native]
	public enum FSPDFObjectType : long
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

	//[Native]
	public enum FSPDFStreamFilter : long
	{
		Unknown = -1,
		NoneDecode = 0,
		ASCIIHexDecode = 1,
		ASCII85Decode = 2,
		LZWDecode = 3,
		FlateDecode = 4,
		RunLengthDecode = 5,
		CCITTFaxDecode = 6,
		JBIG2Decode = 7,
		DCTDecode = 8,
		JPXDecode = 9,
		Crypt = 10
	}

	//[Native]
	public enum FSPDFNumberTreeType : long
	{
		FSPDFNumberTreePageLabels = 1
	}

	//[Native]
	public enum FSRenditionMediaOptionType : long
	{
		MustBeHonored = 0,
		BestEffort = 1
	}

	//[Native]
	public enum FSRenditionMediaPermission : long
	{
		Never = 0,
		Extract = 1,
		Access = 2,
		Always = 3
	}

	//[Native]
	public enum FSRenditionMediaPlayerType : long
	{
		MustUsed = 0,
		Available = 1,
		NotUsed = 2
	}

	//[Native]
	public enum FSRenditionMediaPlayerFitStyle : long
	{
		Meet = 0,
		Slice = 1,
		Fill = 2,
		Scroll = 3,
		Hidden = 4,
		Default = 5
	}

	//[Native]
	public enum FSRenditionWindowType : long
	{
		Floating = 0,
		FullScreen = 1,
		Hidden = 2,
		AnnotRect = 3
	}

	//[Native]
	public enum FSRenditionMonitorSpecifier : long
	{
		Largest = 0,
		Smallest = 1,
		Primary = 2,
		GreatestColorDepth = 3,
		GreatestArea = 4,
		GreatestHeight = 5,
		GreatestWidth = 6
	}

	//[Native]
	public enum FSRenditionFloatingWindowRelatedWindowType : long
	{
		Document = 0,
		Application = 1,
		FullDesktop = 2,
		Monitor = 3
	}

	//[Native]
	public enum FSRenditionFloatingWindowResizeType : long
	{
		No = 0,
		AspectRatio = 1,
		Anyway = 2
	}

	//[Native]
	public enum FSRenditionFloatingWindowOffscreenEvent : long
	{
		None = 0,
		MoveResize = 1,
		NonViable = 2
	}

	//[Native]
	public enum FSDestinationZoomMode : long
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

	//[Native]
	public enum FSActionType : long
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

	//[Native]
	public enum FSActionNewWindowFlag : long
	{
		False = 0,
		True = 1,
		None = 2
	}

	//[Native]
	public enum FSSubmitFormActionFlags : long
	{
		Exclude = 1,
		IncludeNoValueFields = 2,
		ExportFormat = 4,
		GetMethod = 8,
		WithCoordinates = 16,
		AsXFDF = 32,
		IncludeAppendSaves = 64,
		IncludeAnnotations = 128,
		SubmitAsPDF = 256,
		CanonicalFormat = 512,
		ExclNonUserAnnots = 1024,
		ExclFKey = 2048,
		EmbedForm = 8192
	}

	//[Native]
	public enum FSRenditionActionOperationType : long
	{
		None = -1,
		Associate = 0,
		Stop = 1,
		Pause = 2,
		Resume = 3,
		Play = 4
	}

	//[Native]
	public enum FSAdditionalActionTriggerEvent : long
	{
		PageOpened = 0,
		PageClosed = 1,
		DocWillClose = 2,
		DocWillSave = 3,
		DocSaved = 4,
		DocWillPrint = 5,
		DocPrinted = 6,
		FieldKeyStroke = 7,
		FieldWillFormat = 8,
		FieldValueChanged = 9,
		FieldRecalculateValue = 10,
		AnnotCursorEnter = 11,
		AnnotCursorExit = 12,
		AnnotMouseButtonPressed = 13,
		AnnotMouseButtonReleased = 14,
		AnnotReceiveInputFocus = 15,
		AnnotLoseInputFocus = 16,
		AnnotPageOpened = 17,
		AnnotPageClosed = 18,
		AnnotPageVisible = 19,
		AnnotPageInvisible = 20
	}

	//[Native]
	public enum FSDefaultAppearanceDefAPFlags : long
	{
		Font = 1,
		TextColor = 2,
		FontSize = 4
	}

	//[Native]
	public enum FSRichTextStyleCornerMarkStyle : long
	{
		None = 1,
		Superscript = 2,
		Subscript = 3
	}

	//[Native]
	public enum FSBorderInfoStyle : long
	{
		Solid = 0,
		Dashed = 1,
		UnderLine = 2,
		Beveled = 3,
		Inset = 4,
		Cloudy = 5
	}

	//[Native]
	public enum FSIconFitScaleWayType : long
	{
		None = 0,
		Always = 1,
		Bigger = 2,
		Smaller = 3,
		Never = 4
	}

	//[Native]
	public enum FSAnnotType : long
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
		FSAnnot3D = 25,
		Popup = 26,
		Redact = 27,
		RichMedia = 28,
		PagingSeal = 29
	}

	//[Native]
	public enum FSAnnotFlags : long
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

	//[Native]
	public enum FSAnnotHighlightingMode : long
	{
		None = 0,
		Invert = 1,
		Outline = 2,
		Push = 3,
		Toggle = 4
	}

	//[Native]
	public enum FSAnnotProperty : long
	{
		ModifiedDate = 0,
		CreationDate = 1,
		BorderColor = 2,
		FillColor = 3
	}

	//[Native]
	public enum FSAnnotMKEntry : long
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
	public enum FSAnnotMKIconCaptionRelation : long
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
	public enum FSAnnotAppearanceType : long
	{
		Normal = 0,
		Rollover = 1,
		Down = 2
	}

	//[Native]
	public enum FSMarkupStateModel : long
	{
		Marked = 1,
		Review = 2
	}

	//[Native]
	public enum FSMarkupState : long
	{
		None = 0,
		Marked = 1,
		Unmarked = 2,
		Accepted = 3,
		Rejected = 4,
		Cancelled = 5,
		Completed = 6,
		Deferred = 7,
		Future = 8
	}

	//[Native]
	public enum FSMarkupEndingStyle : long
	{
		None = 0,
		Square = 1,
		Circle = 2,
		Diamond = 3,
		OpenArrow = 4,
		ClosedArrow = 5,
		Butt = 6,
		ROpenArrow = 7,
		RClosedArrow = 8,
		Slash = 9
	}

	//[Native]
	public enum FSMarkupMeasureType : long
	{
		X = 0,
		Y = 1,
		D = 2,
		A = 3,
		T = 4,
		S = 5
	}

	//[Native]
	public enum FSLineCapPos : long
	{
		Inline = 0,
		Top = 1
	}

	//[Native]
	public enum FSWidgetLineSpacingStyle : long
	{
		Single = 0,
		OneAndHalf = 1,
		Double = 2,
		ExactValue = 3,
		Auto = 4
	}

	//[Native]
	public enum FSSoundSampleEncodingFormat : long
	{
		Raw = 0,
		Signed = 1,
		MuLaw = 2,
		ALaw = 3
	}

	//[Native]
	public enum FSBookmarkStyle : long
	{
		Normal = 0,
		Italic = 1,
		Bold = 2
	}

	//[Native]
	public enum FSBookmarkPosition : long
	{
		FirstChild = 0,
		LastChild = 1,
		PrevSibling = 2,
		NextSibling = 3,
		FirstSibling = 4,
		LastSibling = 5
	}

	//[Native]
	public enum FSAssociatedFilesRelationship : long
	{
		Unspecified = 0,
		Source = 1,
		Data = 2,
		Alternative = 3,
		Supplement = 4,
		EncryptedPayload = 5,
		FormData = 6,
		Schema = 7
	}

	//[Native]
	public enum FSHeaderFooterContentGeneratorDateFormatType : long
	{
		MSlashD = 0,
		MSlashDSlashYY = 1,
		MSlashDSlashYYYY = 2,
		MMSlashDDSlashYY = 3,
		MMSlashDDSlashYYYY = 4,
		DSlashMSlashYY = 5,
		DSlashMSlashYYYY = 6,
		DDSlashMMSlashYY = 7,
		DDSlashMMSlashYYYY = 8,
		MMSlashYY = 9,
		MMSlashYYYY = 10,
		MDotDDotYY = 11,
		MDotDDotYYYY = 12,
		MMDotDDDotYY = 13,
		MMDotDDDotYYYY = 14,
		MMDotYY = 15,
		DDotMDotYYYY = 16,
		DDDotMMDotYY = 17,
		DDDotMMDotYYYY = 18,
		YYHyphenMMHyphenDD = 19,
		YYYYHyphenMMHyphenDD = 20
	}

	//[Native]
	public enum FSHeaderFooterContentGeneratorPageNumberFormat : long
	{
		Default = 0,
		NumberOfCount = 1,
		NumberSlashCount = 2,
		PageNumber = 3,
		PageNumberOfCount = 4
	}

	//[Native]
	public enum FSTiledWatermarkSettingsFlags : long
	{
		AsPageContents = 0,
		AsAnnot = 1,
		OnTop = 2,
		NoPrint = 4,
		Invisible = 8
	}

	//[Native]
	public enum FSPDFDocPasswordType : long
	{
		Invalid = 0,
		NoPassword = 1,
		User = 2,
		Owner = 3
	}

	//[Native]
	public enum FSPDFDocEncryptType : long
	{
		Unknown = -1,
		None = 0,
		Password = 1,
		Certificate = 2,
		FoxitDRM = 3,
		Custom = 4,
		Rms = 5,
		Cdrm = 6
	}

	//[Native]
	public enum FSPDFDocUserPermissions : long
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

	//[Native]
	public enum FSPDFDocSaveFlags : long
	{
		Normal = 0,
		Incremental = 1,
		NoOriginal = 2,
		XRefStream = 8,
		Linearized = 4096,
		RemoveRedundantObjects = 16,
		NoUpdatingMetadataDateTime = 32
	}

	//[Native]
	public enum FSPDFDocImportPageFlags : long
	{
		Normal = 0,
		WithLayers = 1,
		ShareStream = 2
	}

	//[Native]
	public enum FSPDFDocExtractPagesOptions : long
	{
		Annotation = 1,
		StructureTree = 2,
		Javascript = 4,
		OCProperties = 8,
		ObjectStream = 16,
		AttachFiles = 32
	}

	//[Native]
	public enum FSPDFDocInsertDocOptions : long
	{
		FSPDFDocInsertDocOptionAttachments = 1
	}

	//[Native]
	public enum FSPDFDocDisplayMode : long
	{
		UseNone = 0,
		UseOutlines = 1,
		UseThumbs = 2,
		FullScreen = 3,
		UseOC = 4,
		UseAttachment = 5
	}

	//[Native]
	public enum FSPDFDocDataType : long
	{
		Forms = 1,
		Annots = 2,
		Links = 4
	}

	//[Native]
	public enum FSPDFDocWrapperType : long
	{
		None = 0,
		Foxit = 1,
		Pdfv2 = 2
	}

	//[Native]
	public enum FSFillSignFillSignObjectType : long
	{
		Text = 0,
		CrossMark = 1,
		CheckMark = 2,
		RoundRectangle = 3,
		Line = 4,
		Dot = 5,
		Signature = 6,
		InitialsSignature = 7
	}

	//[Native]
	public enum FSOutputPreviewShowType : long
	{
		All = 0,
		DeviceCMYK = 1,
		NotDeviceCMYK = 2,
		ICCBasedCMYK = 3,
		SpotColor = 4,
		DeviceCMYKAndSpot = 5,
		NotDeviceCMYKOrSpot = 6,
		DeviceN = 7,
		Cmyk = 8,
		Rgb = 9,
		DeviceRGB = 10,
		ICCBasedRGB = 11,
		Gray = 12,
		DeviceGray = 13,
		CalGray = 14,
		Calibrated = 15,
		Lab = 16,
		Device = 17,
		Images = 18,
		SolidColor = 19,
		SmoothShades = 20,
		RegistrationColor = 21,
		Text = 22,
		LineArt = 23
	}

	//[Native]
	public enum FSOutputPreviewColorantType : long
	{
		Process = 0,
		Spot = 1
	}

	//[Native]
	public enum FSLayerTreeUsageState : long
	{
		On = 0,
		Off = 1,
		Unchanged = 2,
		Undefined = 3
	}

	//[Native]
	public enum FSLayerContextUsageType : long
	{
		View = 0,
		Design = 1,
		Print = 2,
		Export = 3,
		Zoom = 4
	}

	//[Native]
	public enum FSGraphicsObjectBlendMode : long
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

	//[Native]
	public enum FSGraphicsObjectType : long
	{
		All = 0,
		Text = 1,
		Path = 2,
		Image = 3,
		Shading = 4,
		FormXObject = 5
	}

	//[Native]
	public enum FSTextStateMode : long
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

	//[Native]
	public enum FSGraphicsObjectsTextMergeOption : long
	{
		None = 0,
		Tjy = 1,
		Btet = 2
	}

	//[Native]
	public enum FSPDFPageParseFlags : long
	{
		Normal = 0,
		TextOnly = 1
	}

	//[Native]
	public enum FSPDFPageCalcMarginMode : long
	{
		ContentsBox = 0,
		Detection = 1
	}

	//[Native]
	public enum FSPDFPageFlattenOptions : long
	{
		All = 0,
		NoAnnot = 1,
		NoFormControl = 2
	}

	//[Native]
	public enum FSPDFPageBoxType : long
	{
		MediaBox = 0,
		CropBox = 1,
		TrimBox = 2,
		ArtBox = 3,
		BleedBox = 4
	}

	//[Native]
	public enum FSPDFPageSize : long
	{
		Letter = 1,
		Legal = 2,
		A2 = 3,
		A3 = 4,
		A4 = 5,
		A5 = 6,
		A6 = 7,
		B2 = 8,
		B3 = 9,
		B4 = 10,
		B5 = 11,
		B6 = 12
	}

	//[Native]
	public enum FSDocViewerPrefsPrintScale : long
	{
		None = 0,
		AppDefault = 1
	}

	//[Native]
	public enum FSDocViewerPrefsViewerPref : long
	{
		HideToolbar = 0,
		HideMenubar = 1,
		HideWindowUI = 2,
		FitWindow = 3,
		CenterWindow = 4,
		DisplayDocTitle = 5
	}

	//[Native]
	public enum FSPageLabelsStyle : long
	{
		None = 0,
		DecimalNums = 1,
		UpperRomanNums = 2,
		LowerRomanNums = 3,
		UpperLetters = 4,
		LowerLetters = 5
	}

	//[Native]
	public enum FSReflowPageFlags : long
	{
		Normal = 0,
		WithImage = 1,
		NoTruncate = 2
	}

	//[Native]
	public enum FSTextPageCharInfoTextCharFlag : long
	{
		Unknown = -1,
		Normal = 0,
		Generated = 1,
		UnUnicode = 2,
		Hyphen = 3,
		ComboWord = 4
	}

	//[Native]
	public enum FSTextPageTextParseFlags : long
	{
		Normal = 0,
		OutputHyphen = 1,
		UseStreamOrder = 2
	}

	//[Native]
	public enum FSTextPageTextOrderFlag : long
	{
		StreamOrder = 0,
		DisplayOrder = 1
	}

	//[Native]
	public enum FSTextSearchSearchFlags : long
	{
		Normal = 0,
		MatchCase = 1,
		MatchWholeWord = 2,
		Consecutive = 4,
		NotMatchFullWidth = 32
	}

	//[Native]
	public enum FSSecurityHandlerCipherType : long
	{
		None = 0,
		Rc4 = 1,
		Aes = 2
	}

	//[Native]
	public enum FSStdSecurityHandlerModifyFlag : long
	{
		Permission = 1,
		UserPassword = 2,
		OwnerPassword = 4
	}

	//[Native]
	public enum FSTabOrderMgrOrderType : long
	{
		None = 0,
		Row = 1,
		Column = 2,
		Structure = 3
	}

	//[Native]
	public enum FSWatermarkSettingsFlags : long
	{
		ASPageContents = 0,
		ASAnnot = 1,
		OnTop = 2,
		NoPrint = 4,
		Invisible = 8,
		ShareImageStream = 16,
		ShareTextStream = 32,
		SharePageStream = 64
	}

	//[Native]
	public enum FSWatermarkTextPropertiesFontStyle : long
	{
		Normal = 0,
		Underline = 1
	}

	//[Native]
	public enum FSFillerAssistCallbackPopupMenuItem : long
	{
		None = 0,
		Cut = 1,
		Copy = 2,
		Paste = 3,
		Delete = 4,
		SelectAll = 5
	}

	//[Native]
	public enum FSFillerVirtualKeyCode : long
	{
		Unknown = 0,
		Back = 8,
		Tab = 9,
		Return = 13,
		Shift = 16,
		Control = 17,
		Menu = 18,
		Pause = 19,
		Escape = 27,
		Space = 32,
		Prior = 33,
		Next = 34,
		End = 35,
		Home = 36,
		Left = 37,
		Up = 38,
		Right = 39,
		Down = 40,
		Print = 42,
		Snapshot = 44,
		Insert = 45,
		Delete = 46,
		Help = 47,
		FSFillerVkey0 = 48,
		FSFillerVkey1 = 49,
		FSFillerVkey2 = 50,
		FSFillerVkey3 = 51,
		FSFillerVkey4 = 52,
		FSFillerVkey5 = 53,
		FSFillerVkey6 = 54,
		FSFillerVkey7 = 55,
		FSFillerVkey8 = 56,
		FSFillerVkey9 = 57,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		Numpad0 = 96,
		Numpad1 = 97,
		Numpad2 = 98,
		Numpad3 = 99,
		Numpad4 = 100,
		Numpad5 = 101,
		Numpad6 = 102,
		Numpad7 = 103,
		Numpad8 = 104,
		Numpad9 = 105,
		Multiply = 106,
		Add = 107,
		Separator = 108,
		Subtract = 109,
		Decimal = 110,
		Divide = 111,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123
	}

	//[Native]
	public enum FSFillerEventFlags : long
	{
		ShiftKey = 1,
		ControlKey = 2,
		AltKey = 4,
		MetaKey = 8,
		KeyPad = 16,
		AutoRepeat = 32,
		LeftButtonDown = 64,
		MiddleButtonDown = 128,
		RightButtonDown = 256,
		Command = 512
	}

	//[Native]
	public enum FSFieldType : long
	{
		Unknown = 0,
		PushButton = 1,
		CheckBox = 2,
		RadioButton = 3,
		ComboBox = 4,
		ListBox = 5,
		TextField = 6,
		Signature = 7
	}

	//[Native]
	public enum FSFieldFlags : long
	{
		ReadOnly = 1,
		Required = 2,
		NoExport = 4,
		ButtonNoToggleToOff = 256,
		ButtonRadiosInUnison = 512,
		TextMultiline = 256,
		TextPassword = 512,
		TextFileSelect = 1024,
		TextNoSpellCheck = 2048,
		TextDoNotScroll = 4096,
		TextComb = 8192,
		ComboEdit = 256,
		ChoiceMultiSelect = 256,
		TextRichText = 16384,
		ChoiceSort = 512,
		ChoiceCommitOnSelChange = 1024
	}

	//[Native]
	public enum FSSignatureStates : ulong
	{
		Unknown = 2147483648L,
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
		VerifyNoChange = 1024,
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
		VerifyTimestampIssueValid = 16777216,
		VerifyTimestampTimeBefore = 33554432,
		CertCannotGetVRI = 67108864,
		VerifyChangeLegal = 134217728,
		VerifyChangeIllegal = 268435456
	}

	//[Native]
	public enum FSSignatureAPFlags : long
	{
		FoxitFlag = 1,
		Label = 2,
		Reason = 4,
		SigningTime = 8,
		Dn = 16,
		Location = 32,
		Signer = 64,
		Bitmap = 128,
		Text = 256,
		FoxitEditorFlag = 512,
		Producer = 1024
	}

	//[Native]
	public enum FSSignatureKeyName : long
	{
		Signer = 0,
		Location = 1,
		Reason = 2,
		ContactInfo = 3,
		Dn = 4,
		Text = 5,
		Producer = 6
	}

	//[Native]
	public enum FSSignatureDigestAlgorithm : long
	{
		FSSignatureDigestSHA1 = 0,
		FSSignatureDigestSHA256 = 1,
		FSSignatureDigestSHA384 = 2,
		FSSignatureDigestSHA512 = 3
	}

	//[Native]
	public enum FSSignatureSignatureType : long
	{
		Ordinary = 0,
		TimeStamp = 3,
		PagingSeal = 4
	}

	//[Native]
	public enum FSSignaturePAdESLevel : long
	{
		NotPAdES = 0,
		None = 1,
		Bb = 2,
		Bt = 3,
		Blt = 4,
		Blta = 5
	}

	//[Native]
	public enum FSSignatureDocPermission : long
	{
		Unrestricted = 0,
		NoChangesAllowed = 1,
		FillingFormAndSigning = 2,
		FillingFormSigningAndAnnotating = 3
	}

	//[Native]
	public enum FSSignatureFieldMDPAction : long
	{
		None = 0,
		All = 1,
		Include = 2,
		Exclude = 3
	}

	//[Native]
	public enum FSSignatureLabelName : long
	{
		Signer = 0,
		Location = 1,
		Reason = 2,
		SignTime = 3,
		Dn = 4,
		Producer = 6
	}

	//[Native]
	public enum FSSignatureCallbackCertValidity : long
	{
		Valid = 0,
		Expired = 1,
		UnsupportType = 2,
		DataError = 3,
		InvalidPassword = 4,
		InvalidPath = 5,
		NotSet = 6,
		CannotGetPrivateKey = 7
	}

	//[Native]
	public enum FSTimeStampServerSendRequestResult : long
	{
		Success = 0,
		FailToCreateSocket = 1,
		FailToConnect = 2,
		FailToSendData = 3,
		FailToReceiveData = 4,
		FailToRequest = 5,
		FailToGetData = 6,
		OutOfMemory = 7
	}

	//[Native]
	public enum FSPagingSealConfigPagingSealPosition : long
	{
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4
	}

	//[Native]
	public enum FSPagingSealConfigPagingSealStyle : long
	{
		MultipleSignatures = 0,
		OneSignature = 1
	}

	//[Native]
	public enum FSPagingSealSignaturePagingSealAPState : long
	{
		Unknown = 0,
		Unsigned = 1,
		Signed = 2,
		Valid = 3,
		Invalid = 4
	}

	//[Native]
	public enum FSResponseResponseType : long
	{
		None = 0,
		Crl = 1,
		Ocsp = 2
	}

	//[Native]
	public enum FSCertVerifyResultCertStatus : long
	{
		Valid = 0,
		Revoked = 1,
		Expired = 2,
		Unknown = 3
	}

	//[Native]
	public enum FSCertVerifyResultRevocationReason : long
	{
		NoStatus = -1,
		Unspecified = 0,
		KeyCompromise = 1,
		CACompromise = 2,
		AffiliationChanged = 3,
		Superseded = 4,
		CessationOfOperation = 5,
		CertificateHold = 6,
		RemoveFromCRL = 7,
		PrivilegeWithDrawn = 8,
		AACompromise = 9
	}

	//[Native]
	public enum FSCertVerifyResultResponseInfoLocation : long
	{
		NotSet = 0,
		Dss = 1,
		Signature = 2,
		Online = 3
	}

	//[Native]
	public enum FSLTVVerifierTimeType : long
	{
		SignatureCreationTime = 0,
		SignatureTSTTime = 1,
		CurrentTime = 2,
		VRICreationTime = 3
	}

	//[Native]
	public enum FSLTVVerifierVerifyMode : long
	{
		FSLTVVerifierVerifyModeAcrobat = 1
	}

	//[Native]
	public enum FSSignatureVerifyResultLTVState : long
	{
		Inactive = 0,
		Enable = 1,
		NotEnable = 2
	}

	//[Native]
	public enum FSPortfolioNodeType : long
	{
		Unknown = 0,
		Folder = 1,
		File = 2
	}

	//[Native]
	public enum FSPortfolioInitialViewMode : long
	{
		UnknownMode = 0,
		DetailMode = 1,
		TileMode = 2,
		Hidden = 3
	}

	//[Native]
	public enum FSAnnotationSummaryCallbackAnnotationSummaryStringID : long
	{
		Author = 0,
		Date = 1,
		Page = 2,
		Type = 3,
		DocumentTitle = 4,
		PageTitle = 5,
		NoAnnotations = 6,
		Number = 7,
		Subject = 8
	}

	//[Native]
	public enum FSAnnotationSummarySettingsSummaryLayout : long
	{
		SeparatePagesWithLine = 0,
		SinglePageWithLine = 1,
		AnnotationOnly = 2,
		SeparatePagesWithSequenceNumber = 3,
		SinglePageWithSequenceNumber = 4
	}

	//[Native]
	public enum FSAnnotationSummarySettingsSortType : long
	{
		Author = 0,
		Date = 1,
		Page = 2,
		AnnotationType = 3
	}

	//[Native]
	public enum FSAnnotationSummarySettingsFontSizeType : long
	{
		Small = 0,
		Medium = 1,
		Large = 2
	}

	public enum PdfLayoutMode 
	{
		Unknown = 0,
		Single,
		Two,
		Reflow,
		TwoLeft,
		TwoRight,
		TwoMiddle
	}

	public enum PdfReflowReflowmode 
	{
		None = 0,
		Withimage = 1,
		Onlytext
	}

	public enum PdfPageBindingEdge 
	{
		Unknown = 0,
		LeftEdge = 1,
		RightEdge = 2
	}

	public enum PdfDisplayZoommode 
	{
		Unknown = 0,
		Fitpage,
		Fitwidth,
		Fitheight
	}

	public enum PdfCropMode
	{
		None = -1,
		Contentsbox,
		Detection,
		Customized
	}

	//[Native]
	public enum FsPagespacingDirection : long
	{
		Horizontal = 1,
		Vertical = 2
	}

	public enum PdfPageStyleType 
	{
		Blank = 0,
		Lined,
		Grid,
		Graph,
		Music
	}

	//[Native]
	public enum FSNightColorMode : ulong
	{
		Default,
		MappingGray
	}

	//[Native]
	public enum FSGestureLockOptions : ulong
	{
		None = 0,
		SingleTap = 1uL << 0,
		DoubleTap = 1uL << 1,
		LongPress = 1uL << 3,
		Pinch = 1uL << 4,
		Pan = 1uL << 5,
		All = SingleTap | DoubleTap | LongPress | Pinch | Pan
	}

	public enum PdfCertErrorCode 
	{
		Sucesss = 0,
		File,
		Password
	}
    public enum PDF_LAYOUT_MODE
    {
        /** @brief  Unknown page mode. */
        PDF_LAYOUT_MODE_UNKNOWN = 0,
        /** @brief  Continuous page mode. */
        PDF_LAYOUT_MODE_CONTINUOUS,
        /** @brief  Single page mode. */
        PDF_LAYOUT_MODE_SINGLE,
        /** @brief  Facing mode. */
        PDF_LAYOUT_MODE_TWO,
        /** @brief  Reflow mode. */
        PDF_LAYOUT_MODE_REFLOW,
        /** @brief  Facing mode. Cover page left */
        PDF_LAYOUT_MODE_TWO_LEFT,
        /** @brief  Facing mode. Cover page right */
        PDF_LAYOUT_MODE_TWO_RIGHT,
        /** @brief  Facing mode. Cover page middle */
        PDF_LAYOUT_MODE_TWO_MIDDLE
    }

    public enum PDF_REFLOW_REFLOWMODE
    {
        /** @brief  No reflow. */
        PDF_REFLOW_NONE = -1,
        /** @brief Reflow both text and image on PDF page. */
        PDF_REFLOW_WITHIMAGE = 0,
        /** @brief Reflow just text on PDF page. */
        PDF_REFLOW_ONLYTEXT
    }

    public enum PDF_DISPLAY_ZOOMMODE
    {
        /** @brief  Zoom mode: unknown. */
        PDF_DISPLAY_ZOOMMODE_UNKNOWN = 0,
        /** @brief  Zoom mode: fit page. */
        PDF_DISPLAY_ZOOMMODE_FITPAGE,
        /** @brief  Zoom mode: fit page width. */
        PDF_DISPLAY_ZOOMMODE_FITWIDTH,
        /** @brief  Zoom mode: fit page height. */
        PDF_DISPLAY_ZOOMMODE_FITHEIGHT
    }

    public enum PDF_CROP_MODE {
        /** @brief  No crop. */
        PDF_CROP_MODE_NONE = -1,
        /** @brief  Crop margin according to bounding box of all contents. */
        PDF_CROP_MODE_CONTENTSBOX,
        /** @brief  Crop margin by detecting paths or images. */
        PDF_CROP_MODE_DETECTION,
        /** @brief  Crop margin with specified pages & rects */
        PDF_CROP_MODE_CUSTOMIZED,
    }
    public enum PDF_PAGE_STYLE_TYPE {
	/** @brief    Insert page blank style. */
    	PDF_PAGE_STYLE_TYPE_BLANK = 0,
    	/** @brief    Insert page lined style. */
    	PDF_PAGE_STYLE_TYPE_LINED,
    	/** @brief    Insert page grid style. */
    	PDF_PAGE_STYLE_TYPE_GRID,
    	/** @brief    Insert page graph style. */
    	PDF_PAGE_STYLE_TYPE_GRAPH,
    	/** @brief    Insert page music style. */
    	PDF_PAGE_STYLE_TYPE_MUSIC
    }
    public enum FS_PAGESPACING_DIRECTION {
    	/** @brief    PageSpcaing horizontal direction. */
    	FS_PAGESPACING_HORIZONTAL = 0x0001,
    	/** @brief    PageSpcaing vertical direction. */
    	FS_PAGESPACING_VERTICAL = 0x0002,
    }

    /**
    * @brief    Enumeration for certificate related error code.
    *
    */
    public enum PDF_CERT_ERROR_CODE {
    	PDF_CERT_ERROR_SUCESSS = 0,
    	/** @brief    File format error or invalid file. */
    	PDF_CERT_ERROR_FILE,
    	/** @brief    Invalid password. */
    	PDF_CERT_ERROR_PASSWORD
    }
    
    /**
    * @brief    Enumeration for page binding edge.
    *
    * @details    Values of this enumeration should be used alone..
    */
    public enum PDF_PAGE_BINDING_EDGE {
        /** The document doesn’t explicitly define a page binding, so the behavior is the same as it is with LEFT_EDGE or RIGHT_EDGE.*/
        PDF_PAGE_BINDING_UNKNOWN = 0,
        /** The document flows from left to right.*/
        PDF_PAGE_BINDING_LEFT_EDGE = 1,
        /** The document flows from right to left.*/
        PDF_PAGE_BINDING_RIGHT_EDGE = 2,
    }



}