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
		SaveAs
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
		FSPermissionStateShow,
		FSPermissionStateNo,
		PermissionStateHide
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
		Flatten
	}

	//[Native]
	public enum FSToolbarType : ulong
	{
		TopBar = 1,
		BottomBar
	}
}
