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

namespace Foxit.iOS.UIExtensions
{
	//[Native]
	public enum FSPanelType : ulong
	{
		Annotation = 1,
		Attachment,
		Outline,
		ReadingBookmark,
		DigitalSignature,
		Custom
	}

	//[Native]
	public enum SettingItemType : ulong
	{
		Single,
		Doublepage,
		Coverpage,
		Daymode,
		Pagecolor,
		Nightmode,
		Continuous,
		Fitpage,
		Fitwidth,
		Reflow,
		Croppage,
		Speech,
		Autoflip,
		Rotate,
		Panzoom
	}

	//[Native]
	public enum FSUIElementType : ulong
	{
		Panel = 20000,
		PanelBookmark,
		PanelOutline,
		PanelComment,
		PanelAttachment,
		PanelDigitalSignature,
		View,
		ViewSinglePage,
		ViewFacing,
		ViewCoverFacing,
		ViewDay,
		ViewNight,
		ViewPageColor,
		ViewContinuousScrolling,
		ViewFitPage,
		ViewFitWidth,
		ViewReflow,
		ViewCropMode,
		ViewSpeak,
		ViewAutoFlip,
		ViewRotateView,
		ViewPanZoom,
		Thumbnial,
		Bookmark,
		Share,
		RecentList,
		ToolsTabHome,
		ToolsTabEdit,
		ToolsTabComment,
		ToolsTabDrawing,
		ToolsTabView,
		ToolsTabForm,
		ToolsTabFillSign,
		HomeBarAddTools,
		ToolbarMultipleSelection,
		EditBarText,
		EditBarImage,
		EditBarAudio,
		EditBarVideo,
		CommentBarNote,
		CommentBarAttachment,
		CommentBarStamp,
		CommentBarTypeWriter,
		CommentBarCallout,
		CommentBarTextbox,
		CommentBarHighlight,
		CommentBarUnderline,
		CommentBarSquiggly,
		CommentBarStrikeout,
		CommentBarInsertText,
		CommentBarReplaceText,
		CommentBarAreaHighlight,
		CommentBarDistance,
		CommentBarImage,
		DrawingBarPencil,
		DrawingBarHighlight,
		DrawingBarEraser,
		DrawingBarRectangle,
		DrawingBarOval,
		DrawingBarLine,
		DrawingBarArrow,
		DrawingBarPolyline,
		DrawingBarPolygon,
		DrawingBarCloud,
		FormBarTextField,
		FormBarCheckBox,
		FormBarRadioButton,
		FormBarListBox,
		FormBarComboBox,
		FormBarSignatureField,
		FormBarImageField,
		FormBarReset,
		AnnotPopMenuAppearance,
		AnnotPopMenuDelete,
		FillSignTypeWriter,
		FillSignComboText,
		FillSignV,
		FillSignX,
		FillSignDot,
		FillSignRectangle,
		FillSignLine,
		FillSignPredefined,
		FillSignSign,
		Search,
		MoreFileProperty,
		MoreProtectRedaction,
		MoreProtectFileEncryption,
		MoreProtectTrustedCertificates,
		MoreProtectCertificateProtect,
		MoreProtectRMSProtect,
		MoreCommentFieldImortComments,
		MoreCommentFieldExportComments,
		MoreCommentFieldSummarizeComments,
		MoreCommentFieldResetFormFields,
		MoreCommentFieldImportFormFields,
		MoreCommentFieldExportFormFields,
		MoreSaveAs,
		MoreExportPDF,
		MoreReduceFileSize,
		MoreTags,
		MorePrint,
		MoreFlatten,
		MoreScreenCapture,
		LongPressComment,
		LongPressRedaction,
		LongPressSign,
		LongPressCopyText,
		LongPressHighlight,
		LongPressUnderline,
		LongPressStrikeout,
		LongPressSquiggly,
		LongPressSpeak,
		GotoPage,
		FullScreenBookmark,
		FullScreenToolbar,
		FullScreenToolbarDrag,
		ToolbarDrag,
		FreeTrial
	}

	//[Native]
	public enum FSUIManagerState : ulong
	{
		Normal = 1,
		Reflow,
		Search,
		AnnotTool,
		PanZoom,
		CreateForm,
		Speech,
		FillSign,
		AutoFlip,
		Redaction,
		Comparision,
		Editor
	}

	//[Native]
	public enum FSInteractiveScene : ulong
	{
		Undefine,
		FillingForms
	}

	//[Native]
	public enum FSDataSortComparison : ulong
	{
		Ascending,
		Descending
	}

	//[Native]
	public enum FSReadToolSettingsType : ulong
	{
		Text = 1,
		Image,
		Audio,
		Video,
		Link,
		Note = 100,
		Attachments,
		Stamp,
		Typewriter,
		Textbox,
		Callout,
		Highlight,
		Underline,
		Squiggly,
		Strikeout,
		ReplaceText,
		InsertText,
		AreaHighlight,
		Measure,
		ImageAnnotation,
		Pencil = 200,
		Highlighter,
		Eraser,
		Rectangle,
		Oval,
		Line,
		Arrow,
		Polygon,
		PolyLine,
		Cloud,
		TextField = 300,
		CheckBox,
		RadioButton,
		ComboBox,
		ListBox,
		SignatureField,
		ImageField,
		FillSignText = 400,
		FillSignSegText,
		FillSignProfile,
		FillSignCheckMark,
		FillSignCrossMark,
		FillSignDot,
		FillSignLine,
		FillSignRoundRectangle,
		DigitalSignature = 500,
		Redact
	}

	//[Native]
	public enum FSReadToolbarItemType : ulong
	{
		Exist,
		Custom
	}

	//[Native]
	public enum FSMenuViewType : ulong
	{
		ThumbnailInsertBlankPagePop = 0,
		Extract,
		SaveAs,
		ViewSecurityPermission,
		Unsupported
	}

	//[Native]
	public enum FSMainToolbarItemPosition : long
	{
		Left = 0,
		Center,
		Right
	}

	//[Native]
	public enum FSMainTopbarToolTag : ulong
	{
		Home,
		Edit,
		Comment,
		Drawing,
		View,
		Form,
		Sign,
		Custom
	}

	//[Native]
	public enum FSMainToolbarItemType : ulong
	{
		Unknown = 0,
		Back,
		More,
		Search,
		Pan,
		AddTool,
		Redo,
		Undo,
		Property,
		MultiSelect,
		Divide,
		Panel,
		ViewSettings,
		Thumbnail,
		ReadingBookmark
	}

	//[Native]
	public enum FSTopbarSubitemContentViewPosition : ulong
	{
		Top,
		Left,
		Right
	}

	//[Native]
	public enum FSMenuControlScene : ulong
	{
		SelectedText,
		BlankSpace
	}

	//[Native]
	public enum FSPermissionState : ulong
	{
		Show,
		No,
		Hide
	}

	//[Native]
	public enum FSFunction : ulong
	{
		MultiMediaEdit,
		DocInfoEdit,
		Edit,
		Reduce,
		PDFDigitalSignAdd,
		Rms,
		DigitalSignField,
		Redaction,
		CanSaveToLocal,
		StandEncrypt,
		Flatten,
		PDFSign,
		PDFBookMark,
		SmallBottomBarToolItem,
		ImageAnnoteItem,
		AttachmentsPanelAddItem
	}

	//[Native]
	public enum FSToolbarType : ulong
	{
		TopBar = 1,
		BottomBar
	}
}
