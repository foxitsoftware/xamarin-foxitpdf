# Foxit PDF SDK For iOS & Android Release Notes

## Version 9.1.1.2
**Release Date**: November 06, 2025

### Bug Fixes
- **[Android] Fixed Crash When Pasting Large Content Into Form Fields:**
  - Fixed an issue where pasting large amounts of text into a form field would cause the application to crash. The application would also crash when deleting text after pasting.
  - **Note:** This fix is also included in Foxit.Android 9.1.0.3.
---

## Version 9.1.1
**Release Date**: October 16, 2025

### Bug Fixes 
- **[Andoroid.Uiextensions]Fixed Android 16KB Page Size Compatibility Issues:**
  - Updated the Scanning Add-on (`FoxitMobileScanningRDK.aar`) and Digital Ink Recognition library (`libdigitalink.so` from [Google ML Kit](https://developers.google.com/ml-kit/vision/digital-ink-recognition)) to fully support devices with [16KB memory page size](https://developer.android.com/guide/practices/page-sizes), ensuring seamless operation on Android 15+ devices with this configuration.

---

## Version 9.1.0
**Release Date**: May 19, 2025

### New Features & Enhancements

#### UIExtensions
- **Optimized Voice Reader Experience:**
  - Users can now switch languages and voices at any time during playback. The build-in langauges are English and Chinese, other languages can be downloaded as needed.
- **Handwritten Text Recognition and Conversion:**
  - Integrated Google ML Kit to support intelligent conversion of handwritten notes (pencil input) into editable text (typewriter annotations). This feature is disabled by default; please refer to the developer manual for enabling instructions.
- **Enhanced Background Removal for Image Signatures:**
  - Improved the ability to remove backgrounds from image signatures, now capable of handling more complex background scenarios than before.
- **Android 15 Edge-to-Edge Display Support:**
  - Migrated to the latest Android APIs to provide an immersive edge-to-edge display experience for Android 15 devices with targetSDK 35.
- **Enhanced Handwriting Experience:**
  - This new version now has improved handwriting responsiveness, addressing the slight slowdown reported previously. Curve strokes are now rendered more smoothly and continuously, resolving the issue of occasional breaks.
- **Enhanced Eraser Experience:**
  - This new version significantly improves the responsiveness and smoothness of the eraser tool by implementing a caching mechanism for `pdfPage.getDisplayMatrix()` within UIExtension. This optimization avoids redundant calculations of the display matrix, leading to a noticeably better user experience.

#### PDFViewCtrl
- **View Locking Functionality:**
  - Added the `pdfViewerCtrl.setGestureLockFlags(PDFViewCtrl.GESTURE_LOCK_PAN | PDFViewCtrl.GESTURE_LOCK_PINCH | PDFViewCtrl.GESTURE_LOCK_DOUBLE_TAP)` API, allowing developers to lock pan, pinch-zoom, and double-tap gestures on the current view, effectively preventing accidental view shifting during annotation and other operations.
- **Ink Stroke Timeout Control:**
  - Introduced the `setInkDrawingTimeout()` and `getInkDrawingTimeout()` APIs, enabling developers to customize the time interval threshold between ink points for more precise control over ink stroke end detection.
- **Precise Area Zoom and Navigation:**
  - Added the `void com.foxit.sdk.PDFViewCtrl.zoomToRect (int pageIndex, RectF pageViewRect, int fitMode )` API, allowing developers to directly navigate to and zoom into a specific area within a page using a specified fit mode.

#### PDFCore
- **Core Engine Upgrade:**
  - The PDFCore API has been updated to the latest Foxit PDF SDK 10.1 version, bringing more powerful underlying PDF processing capabilities and the latest feature support.

#### Cordova Framework
- **Cordova Framework Enhancements:**
  - Updated the Cordova framework to provide more UI customization options and automatic document saving functionality.
  - New APIs:
    - `window.FoxitPdf.setPrimaryColor`: Sets the primary color.
    - `window.FoxitPdf.setToolbarBackgroundColor`: Sets the background color of a toolbar based on its position.
    - `window.FoxitPdf.setTabItemSelectedColor`: Sets the selected tab item color for the tab action bar, supporting both light and dark modes.
    - `window.FoxitPdf.setToolbarItemVisible`: Sets the visibility of toolbar items.
    - `window.FoxitPdf.setAutoSaveDoc`: Enables automatic document saving.

### Bug Fixes
- Fixed a crash in specific XFA forms when filling text fields due to pointer changes during rich text XML regeneration.
- [iOS] Fixed an issue where the ReactNative SDK failed to run on iOS devices.
- [Maui Android] Fixed an issue where the input area and the actual input area were inconsistent when filling out form fields.
- [Maui Android] Fixed an issue where the interface would freeze after selecting a checkbox and then zooming in on the page.
- [iOS] Fixed an issue where the application would crash after drawing multiple objects with a pencil and then using the eraser to erase them.
- Fixed an issue where the file size would increase due to FontMap not being shared when adding FreeText.
- Fixed a crash during signature creation after screen rotation due to Activity restart leading to abnormal signature drawing state.
- Fixed an issue where adding Screen type annotations without setting BorderInfo would result in black borders.
- Fixed an issue where the pencil stroke transparency setting would not take effect immediately after drawing.
- [iOS] Fixed an issue where the font size of FreeText would change randomly when zooming in/out of a PDF document.
- [iOS] Fixed an issue where the writing trajectory would be unsmooth and have sharp corners when writing with a pencil.
- Fixed an issue where the page would sometimes crash after setting the display mode to two-page view, the zoom mode to fit height, and performing multiple zoom operations.
- Fixed an issue where the application would sometimes crash with a NullPointerException because mSeekBarItem was null after the user performed a pinch zoom operation in pan zoom mode.
- Fixed an issue where specific documents would crash when executing `executeJavaScript`.
- Fixed an issue where fonts would not be displayed correctly after opening a PDF with unembedded fonts via the SDK Demo.
- Fixed an issue where Type3 fonts would be rendered abnormally in specific PDF documents.
- Fixed an issue where adding annotations in UIExtension while modifying the annotation area would cause a crash.
- Fixed an issue where some text or image objects would load abnormally when loading a PDF using `openDocFromUrl`.
- [Android] Fixed an issue where calling `importFromFDF` would cause a crash with a SIGSEGV error.
- Fixed an issue where the table of contents containing CJK characters would not display content.

---

## Version 9.0.0
**Release Date**: November 27, 2023

### New Features & Enhancements
- **New Event Handling for Reflowing Pages:**
  - Introduces the "IReflowEventListener" interface in the ReflowPage class with functions "onWillStartParseReflowPage" and "onParsedReflowPage" for invoking objects from PDFViewCtrl.
- **New Event Handling for Renderer:**
  - Introduces the "IRenderEventListener" interface in the Render class with functions "onWillRender" and "onRenderedFlags" for invoking objects from PDFViewCtrl.
- **Support for Displaying Logical Page Numbers:**
  - Adds a new API `useLogicalPageNumbers` to control the display of logical page numbers.
- **Toolbar Position Customization:**
  - Adds new APIs, 'setToolBarPosition' and 'getToolBarPosition,' for customizing the toolbar's position.
- **Multiline Tiled Watermarks Support with Options:**
  - Introduces the 'TiledWatermarkSettings' class and 'StartAddTiledWatermark()' functions to add text, image, or page-based tiled watermarks to PDF pages.
- **Enhancement to the Double-Tap Event Listener:**
  - Improves 'PDFViewCtrl.IDoubleTapEventListener' to support enabling/disabling zooming during a double-tap gesture event.
- **Enhancement to the Page Event Listener:**
  - Adds a new callback interface "onPageSwiped" to the "PDFViewerCtrl.IPageEventListner" to detect page swiping.
- **[Android] Enhancement to the Document Event Listener:**
  - Adds a new callback interface "onDocLoading" to the "PDFViewCtrl.IDocEventListener" to set the loading progress when opening a document.
- **[Android] Adjustment for Ink Annotation to Store PSlink Pressure-Sensitive Data:**
  - Enables annotations drawn using PSI to be saved in the standard PDF ink annotation format, allowing recognition by other PDF editors or viewers.

### Bug Fixes
- Fixed an issue where enabling continuous view and selecting a thumbnail would incorrectly navigate to the wrong page.
- Addressed the scan API malfunction for Android API 30 and later versions due to adaptation issues.
- Resolved an issue where setting ZOOMMODE_FITPAGE via code did not take effect in the page display.
- Fixed the occurrence of a black flash on iOS devices while sliding pages after setting PageColor.
- Corrected the lack of keyword highlighting in search results displayed on the page.
- Fixed the inability to modify properties within the loaded configuration using the Android UIExtension config API.
- Resolved the problem of incomplete thumbnail loading after opening specific files.
- Fixed the incorrect index retrieval via getIndexAtPos after selecting annotations.
- Addressed the occurrence of a white screen and flash upon switching the screen orientation from vertical to horizontal.
- Corrected annotation misplacement after scaling pages when Markup annotations were selected.
- Resolved an issue of missing invocation of the dealloc method upon exiting the demo on iOS devices.

---

## Version 8.4.0
**Release Date**: March 21, 2023

### New Features & Changes
- [UI] The "Add Signature" and "Fill & Sign" features support transparent background by removing the white background of an image signature.
- [UI] Support to save the cropped pages into PDF.
- [UI] Support to export highlighted text into .txt format file.
- [UI] Signature scaling: The signature field now has the ability to scale proportionally.
- [UI-iOS] Increase the brightness of content such as text and annotations in night mode.
- [UI] The drawing markups, Rectangle, Oval, Polygon and Cloud, have options to set the fill color.
- [UI] Bookmark panel supports bookmark rearrangement.
- [iOS] Support to disable or enable Bluetooth feature.
- **Improvements for Drawing:**
  - [UI] Finer Control Over line: The minimal value for line thickness for the Pencil and Highlighter tools has been expanded from 1pt to 0.1pt, allowing to draw more finer lines.
  - [UI-Android] The Pencil, Highlighter and Eraser tools offer an option to enable or disable finger touch while drawing.
- [UI] Improvements to the UX of Scan to PDF feature.
- [Android] Upgraded UIExtension project to target API 31 to align with the changes in Android 12, which now require apps to explicitly declare exported components.
- [Android] Upgraded OpenSSL to version 1.1.1s to remediate the issue caused by a bad OpenSSL version, which can cause the app to crash.
- RDK React Native and Flutter plugin support open URL documents.
- Improved font rendering performance.

### Behavior Changes
- Disable the ability to edit text with rich formatting, but allow for deletion, flattening, and copying.

### Bug Fixes
- [iOS] Fixed issue with inconsistent display scale in reflow mode across various devices.
- [Xamarin Android] Corrected issue that was causing sticky note can be edited even permission is set to false.
- [Flutter Android] Resolved issue where using Flutter to build Android apps failed if targeting Android SDK 31.
- [Xamarin iOS] Addressed issue that was causing Undo button work improperly for FreeText on iOS.
- [Xamarin Android] Resolved issue that was causing Unsafe cipher mode security error in Google prelaunch when deploying the app to Play store.
- Fixed issue where the date field was working improperly when picking up the date from the date picker.
- Resolved issue where downsampling certain type of images resulted in incorrect rendering.
- [Android] Corrected issue where the fill color of a polygon annotation would disappear when the polygon was selected, deleted or modified.
- [Android] Fixed issue that was causing the app to crash when open PDF documents multiple times.
- [Android] Resolved issue where the typewriter display was incorrect by importing FDF data that had been exported after adding a new typewriter.
- Addressed issue that was preventing the newly added XFA widget fields from rendering on the correct page.
- [Android] Fixed issue related to the rendering of bitmap565 images, which were previously rendering inaccurately.
- Resolved issue that was causing certain large glyphs to fail to render after being magnified.
- Fixed issue related to the rendering of sharp angles on the path of Bezier curves.
- Resolved memory leak issue that occurred after calling setAttachedActivity. The problem arose when setting the activity to PdfViewCtrl, which would set com.foxit.sdk.SDKUtil as a singleton and could result in a memory leak.
- Corrected issue where using page.setSize resulted in incorrect page dimensions the first time it was used. This issue occurred when the page's media box top value was smaller than the bottom value.

---

## Version 8.3.0
**Release Date**: July 21, 2022

### Core API Updates
- New API for Freetext annotations to support text-overflow
  - Related API: foxit::pdf::annots::FreeText::AllowTextOverflow
- New PDF class to support seal.
  - Related Class: foxit::pdf::PagingSealSignature
- The GenerateComparedDoc was added with a new flag show all document comparison result's layers
  - Related API: foxit::addon::comparison::Comparison::GenerateComparedDoc
- 1bbp RGB support for Image.AddFrame() Method
  - Related info: enum foxit::common::Bitmap::DIBFormat

### New Features & Changes
- New functions to set the height and width of the toolbar.
- New functions to control annotation permissions.
- New function to control the drawing way that uses the only capacitive stylus or both stylus and finger on Android.
- New function to Support for right-to-left page reading.
- [UI] Support for additional action (AAction) to open a local or URL file.
- [UI] Support for hiding the page number in the lower-left corner in full-screen mode.
- [UI] Support for adding custom stamps with customized contents.
- [UI] Support for the auto-complete feature to auto-fill in form fields.
- [UI] Support for editing Outline, including adding, renaming, moving, moving to a subdirectory or moving to the root directory.
- [UI] Enhanced the eraser to wipe out objects by entire shapes or by pixels.
- [UI] Enhanced the form functionality with the support for creating/editing image fields and recognizing date fields.
- [UI] Enhanced the Typewriter so that the typed entries area with the Typewriter Tool can be moved and resized by its border.
- [UI] Enhanced the top Tab bar with a responsive design on PAD, so it can automatically adapt to the different screen sizes.
- [UI] Enhanced the Home toolbar customization by allowing for reordering tools with drag & drop.

### Bug Fixes
- Fixed crash issue when calling getAnnotAtPoint function on specific documents with no page objects.
- Fixed the issue where the pencil annotation is not cleared with the eraser tool.
- [Android] Fixed an issue where setting the maximum zoom limit doesn't work.
- [Android] Fixed an issue with ConcurrentModificationException occurring on Android.
- [Android] Fixed an issue with deleting form field text.
- [Android] Fixed the memory leak issues.
- [Android] Fixed the displaying issue when the line annotation is selected in the facing mode.
- [Android] Fixed the issue where setting UiextenisonsManager#enableLinks doesn't work.
- [Android] Fixed the crash issue when loading a PDF into the current tab of a viewPager.
- [Android] Fixed the crash issue when loading or switching between different documents.
- [Android] Fixed slowing rendering on certain PDF pages containing large images.
- [Android] Fixed page deformation of certain PDF files when rendering.
- [Android] Fixed the position of the page scroll bar is inconsistent with the finger touch point.
- [Android] Fixed issue where the border blocked the bottom of the text in the Text Box.
- [Android] Fixed the issue where the typed text with the Typewriter Tool inserts in the wrong location.
- [Android] Fixed the annotation selection issue in the editing mode.
- [Android] Fixed the issue where the continuous layout will be toggled to the single layout when the current file contains only one page.
- [iOS] Fixed issue where the multi-line typewriting contents reflow to a single line after moving.
- [iOS] Fixed an issue where the typed entry with the Typewriter Tool cannot be moved when there is only one character with a font size less than 12.
- [iOS] Fixed the crash on initializing the gesture recognizer.
- [iOS] Fixed the crash issue caused by the APP memory sudden surging when adding Typewriter on an enlarged page.

---

## Version 8.2.0
**Release Date**: November 29, 2021

### Core API Updates
- The TOC was added a new configuration option to set if to include the catalog page.
  - Relevant API: foxit::pdf::TableOfContentsConfig::TableOfContentsConfig(); void foxit::pdf::TableOfContentsConfig::Set()
- New Timestamp callback function which supports customers to connect own custom timestamp services
  - Relevant class: foxit::pdf::TimeStampCallback Class
- New XFADoc::ImportData() implementation to import XFA data (XML/XDP) from memory.
  - Relevant API: foxit::addon::xfa::XFADoc::ImportData
- Get user's input data when invalid value is added to form field
  - Relevant API: foxit::pdf::interform::FillerAssistCallback::ReportInvalidValue
- New functions to get all annotation objects at a specific coordinate point
  - Relevant API:
    - annots::Annot foxit::pdf::PDFPage::GetAnnotsAtPoint
    - annots::Annot foxit::pdf::PDFPage::GetAnnotsAtDevicePoint

### New Features & Changes
- New add bookmark function in Reflow mode
- Support to use Apple Pencil to annotate PDFs, turn pages and switch between pen and eraser.
- Support for validating the signature after singing on iOS.
- New API PDFViewCtrl.setKeepZoomRatio() to control zoom ratio for the same page turning.
- Enhanced UI performance on Android.
- Optimized the field.setValue() processing time for XFA document.
- Improved the print quality by reset page rendering bmp size on Android.
- Optimized ink annotation to prevent flickering while writing.
- Optimized the text display effect in reflow mode on Android.

### Bug Fixes
- The link issue of a specific document on Android.
- A crash when calling doc.getUserPermissions().
- Unsafe cipher mode security error in Google prelaunch.
- A permission issue that disabling annotation also disables adding signature.
- Menus are disabled with json readingBookmark is set as false when creating a new project on Xamarin.iOS.
- The failure of multithreaded doc loading on Android.
- A crash when removing tabs on Xamarin.Android
- A crash when inserting readingBookmark.
- The font displaying issue of the number 0 and the capital letter O on Android.
- An issue where unable to enter pentagram on Android.

---

## Version 8.1.0
**Release Date**: August 31, 2021

### Core API
- Updated Core API to Foxit PDF SDK 8.1

### New Features & Changes
- **Migrate Android and Xamarin.Android to AndroidX:**
  - By migrating ADAL to MSAL
- Chrome book
- Split View feature on iPad
- Support for Android 11 (target API level 30)
- Fill&Sign supports for Undo/Redo.
- Disable/Enable the highlight of a signature field.
- Add "Speak" and "Copy Text" into the context menu of the area highlight comment.
- Long press to copy contents in the text field.
- Turn pages with finger swiping when annotation tool is in selection.
  - In previous version, users can't turn pages when annotation tool is in selection, until they unselect the annotation tool.
- Edit existing annotation when annotation tool is in selection.
  - In previous version, users have to unselect the annotation tool before editing.
- Enhanced the viewport calculation to better adapt the page layout with system status bar shown.
- Removed 2 unnecessary permissions requested in AndroiManifest: MANAGE_ACCOUNTS and MOUNT_UNMOUNT_FILESYSTEMS.

### Demo
- Annotation demo adds 'export annotation data to JSAON' sample code.

### Bug Fixes
- Xamarin Android crash if camera is triggered.
- The foreground and background color setting is unexpected in a specific calling order.
- Unable to remove tab menu when it is in horizontal screen on Android tablets.

---

## Version 8.0.0611
**Release Date**: June 11, 2021

### Bug Fixes
- Fix a bug related to page number slider.

---

## Version 8.0
**Release Date**: June 08, 2021

This is a major version with a new user interface

### Core API Updates
- **New Annotation Summary List**
  - related API: foxit.sdk.pdf.AnnotationSummary

### New Features
- New event to detect if a certificate-based signature has been applied to a document
  - related API: onDigitalSignatureSigned:
- Support scoped storage functionality as per Android 11 requirements
- Area Highlight
- Annotation Summary List at User Interface
- Support brush type for pencil annotations
- Dark Mode for Android
- Auto Flip
- Outline editing
- Enhance search function (Support Outline, Bookmark, Annotation, Redaction search)
- Add tool preference setting in Home Tab
- Support to add link annotations in Edit tab
- Custom page color
- Support to redact one or more pages

### Demos
- Main demo updated with new user interface

### Bug Fixes
- "/r/n" bug for Multiline XFA forms
- RegisterSecurityCallback issue for Xamarin
- Not possible to autosave files containing digital signatures
- Signer name not displayed in the signature panel
- Rendering issue on continuous view mode
- Keyboard overlapping when filling PDF forms

---

## Version 7.6
**Release Date**: March 22, 2021

Version 7.6 is a maintenance release

### Enhancement
- Enhance the performance of documents containing static XFA forms

### Bug Fixes
- Annotation count incorrect for specific files
- Rendering issue of specific form fields when zooming
- Form filling issue in some special case
- Fixed issue related to opening RMS encrypted files

---

## Version 7.5.1
**Release Date**: January 21, 2021

Version 7.5.1 is a maintenance version

### Update
- Upgrade the minium iOS support to iOS 11
- Fix an issue (that RMS protetected file cannot be opend) caused by RMS SDK 4.2.x released before March 2020

---

## Version 7.5
**Release Date**: November 23, 2020

Version 7.5 is a minor release

### New Features
- Toolbar buttons visibility toggle in Cordova
- New AddLanguage methodfunction in Xamarin Android
- Support to create Popup Annotation when a markup annotation created
- Support Undo/Redo step by step for pencil tool
- Add onDocModified event for RDK at UI Level
  - Related API:
    - Android:
      - void com.foxit.uiextensions.UIExtensionsManager.registerDocModifiedEventListener(IDocModifiedEventListener listener)
      - void com.foxit.uiextensions.UIExtensionsManager.unregisterDocModifiedEventListener(IDocModifiedEventListener listener)
      - void com.foxit.uiextensions.UIExtensionsManager.IDocModifiedEventListener.onDocModified(PDFDoc doc)
    - iOS:
      - (void)onDocModified:(FSPDFDoc *)doc;
      - (void)registerDocModifiedEventListener:(id<IDocModifiedEventListener>)listener {}
      - (void)unregisterDocModifiedEventListener:(id<IDocModifiedEventListener>)listener {}
- New autosave flag for signatures
  - Related API:
    - Android:
      - boolean com.foxit.uiextensions.UIExtensionsManager.isAutoSaveSignedDoc()
      - void com.foxit.uiextensions.UIExtensionsManager.setAutoSaveDoc(boolean autoSaveDoc)
      - void com.foxit.uiextensions.UIExtensionsManager.setSignedDocSavePath(String savePath)
      - String com.foxit.uiextensions.UIExtensionsManager.getSignedDocSavePath( )
    - iOS:
      - (BOOL) isAutoSaveSignedDoc
      - (NSString*) signedDocSavePath
- Page turning touch screen gesture supported at UI Level (Android)
- New API to set the Page Flipping mode (Android)
  - Related API:
    - void com.foxit.sdk.PDFViewCtrl.enablePageFlippingByTouchBorder(boolean pageFlipping)
- Set method for text Label on Signature Form Field
  - Related API:
    - void foxit::pdf::Signature::SetKeyLabel (LabelName label_name, const wchar_t * label_value )
    - WString foxit::pdf::Signature::GetKeyLabel(LabelName label_name)
- Provide API to support MoveObject
  - Related API:
    - POSITION foxit::pdf::GraphicsObjects::MoveGraphicsObjectByPosition(POSITION current_position,POSITION position_move_after)
    - POSITION foxit::pdf::GraphicsObjects::GetGraphicsObjectPosition (graphics::GraphicsObject *raphics_object)
- Embedded fonts supported on Header/Footer creation
  - Related API:
    - Added following member to foxit::pdf::HeaderFooter Class:
      - /** @brief A boolean value that decides whether to embed font or not. */
      - bool is_embed_font;
      - /** @brief A boolean value that decides whether to underline text or not. */
      - bool is_underline;
- Support Rich text for FreeText Annotations
  - Related Class/API:
    - foxit::pdf::RichTextStyle Class
    - WString foxit::pdf::annots::Markup::GetRichTextContent(int32 index)
    - int32 foxit::pdf::annots::Markup::GetRichTextCount()
    - RichTextStyle foxit::pdf::annots::Markup::GetRichTextStyle(int32 index)
    - void foxit::pdf::annots::Markup::RemoveRichText(int index)
    - void foxit::pdf::annots::Markup::InsertRichText(int32 index,const WString & content,const RichTextStyle & style )
- Method to enable/disable bezier curve when setting ink (pencil) annotation's appearance
  - related API:
    - void foxit::pdf::annots::Ink::EnableUseBezier(bool use_bezier)

### Demos
- New Demos: image2pdf, Watermark, search, graphics_objects
- Ehnance the annotation demo

### Bug Fixes
- Adding annotations in multi tab mode issue fixed
- XFA Form filling related issues
- Background color missing when objects are selected
- Form filling issues related to Japanese text

---

## Version 7.4
**Release Date**: September 28, 2020

Version 7.4 is a minor release

### New Features
- Fill & Sign Feature at UI Level
- Support to render the RMS files with RMS watermark.
- Provide API Scroll to next/Previous Page
  - related APIs (Android):
    - void com.foxit.sdk.PDFViewCtrl.slideToPreviousScreen ( )
    - void com.foxit.sdk.PDFViewCtrl.slideToNextScreen ( )
- Provide API to apply an annotation's property to the ToolHandler
  - Related API:
    - boolean com.foxit.uiextensions.UIExtensionsManager.canUpdateAnnotDefaultProperties ( )
    - (BOOL) canUpdateAnnotDefaultProperties
- Provide API to set the HighLight of Form Field Color For iOS
  - Related API:
    - /** @brief Get/Set the highlight color for form. */
    - @property (nonatomic, strong) UIColor *highlightFormColor;
    - /** @brief Whether to allow to highlight form. */
    - @property (nonatomic, assign) BOOL highlightForm;
- Provide API to Set/Get the Annotation Author
  - Related API:
    - Android:
      - String com.foxit.uiextensions.UIExtensionsManager.getAnnotAuthor ( )
      - void com.foxit.uiextensions.UIExtensionsManager.setAnnotAuthor ( String author )
    - iOS:
      - (NSString*) annotAuthor
- "AnnotContent" method Stamp and FileAttachment
- Enable/Disable FormHighlight can be take effect immediately
  - For Andorid:
    - setFormHighlightColor
    - pdfViewerCtrl.updatePagesLayout()
  - For iOS:
    - enableHighlightForm
    - [FSPDFViewCtrl Refresh]

### Bug Fixes
- Fixed a bug related to move the Freetext annot with multi-line test that the Font size is larger than 48px

**Notice**: Minimum Android support update to API 19 (Android 4.4)

### Updated Core API to Foxit PDF SDK 7.4

#### New Features
- Get the name of color separation and Support Rendering PDF with Color separation (OutPut Preview)
  - Relateds API:
    - static void foxit::common::Library::SetDefaultICCProfilesPath ( const wchar_t * icc_profile_folder_path )
    - bool foxit::common::ColorSpace::IsSpotColorSpace ( ) const
    - StringArray foxit::common::ColorSpace::GetComponentNames ( ) const
  - Related Class:
    - foxit::pdf::OutputPreview
- Provide High Level API for PDF Combination
  - Related class: foxit::pdf::Combination
- Provide API to deep Clone a PDF Object
  - Related API: PDFObject* foxit::pdf::objects::PDFObject::DeepCloneObject ( ) const
- Set method for first character index on Document level Search feature
  - Related API:
    - bool foxit::pdf::TextSearch::SetStartCharacter(int char_index)
- New flags for performing Document level Text Search according to stream order or appearance order
  - Related API:
    - foxit::pdf::TextSearch::TextSearch ( const PDFDoc & document,SearchCancelCallback * cancel = 0,int flags = foxit::pdf::TextPage::e_ParseTextNormal )
- Fill and Sign feature API
  - Related class:
    - foxit::pdf::FillSign
    - foxit::pdf::FillSignObject
- New Get method for retrieving GraphicObjects in a specific rectangle
  - Related API:
    - graphics::GraphicsObjectArray foxit::pdf::PDFPage::GetGraphicsObjectsAtRectangle ( const RectF & rect,graphics::GraphicsObject::Type filter = graphics::GraphicsObject::e_TypeAll )
    - graphics::GraphicsObject* foxit::pdf::PDFPage::GetGraphicsObjectAtRectangle ( const RectF & rect, graphics::GraphicsObject::Type filter = graphics::GraphicsObject::e_TypeAll ) const

#### Enhancement
- Enhance the watermark feature
- Enhance the JS feature
- Enhance the print effect for PDF file containing FormField

#### Bug Fixed
- Fixed a crash issue for a special file containing JavaScript code

---

## Version 7.3.0.0730
**Release Date**: August 04, 2020

Version 7.3.0.0730 with hotfix. This is a maintenance release.

### Bug Fixes
- Fixed incorrect naming for compression format type: e_ImageCompressJPEG2 to e_ImageCompressJBIG2

---

## Version 7.3
**Release Date**: July 01, 2020

Version 7.3 is a minor release

### New Platform Support
- Support for Mac Catalyst

### New Features
- Provide options to enable/disable slide mode for Android which will enhance the e-ink screen rendering
- Support Group Annotations at UI Level
- New Text to Speech - Read Out Loud feature
- Provide option to enable/disable auto save feature

### Enhancement
- Encryption key parameter of CertificateSecurityHandler.initialize method modified from string to byte[]

### Updated Core API to Foxit PDF SDK 7.3
- New layer methods: Creating dictionary, adding new and checking for layers in a PDF
  - Related APIs/Classes:
    - bool foxit::pdf::PDFDoc::HasLayer ( ) const
    - foxit::pdf::LayerTree::LayerTree ( const PDFDoc & document ) //If there is no layer tree in the PDF document which can be verified by method PDFDoc::HasLayer, the constructed layer tree object will build layer related dictionary
- Support getting PDF Objects by Object Index
  - Related API/Class:
    - int foxit::pdf::GraphicsObjects::GetGraphicsObjectCount ( ) const
    - int foxit::pdf::GraphicsObjects::GetGraphicsObjectIndex ( graphics::GraphicsObject * graphics_object ) const
- New option to render annotation for thumbnails (ignore NoZoom/NoRotate flags)
  - Related APIs/Classes:
    - void foxit::common::Renderer::SetRenderAnnotsForThumbnail ( bool is_render_annots_for_thumbnail )
- New Get/Set permisson methods to signature feature
  - Related APIs/Classes:
    - enum foxit::pdf::Signature::DocPermission
    - enum foxit::pdf::Signature::FieldMDPAction
    - void foxit::pdf::Signature::SetDocPermission ( DocPermission permission )
    - DocPermission foxit::pdf::Signature::GetDocPermission ( )
    - FieldMDPAction foxit::pdf::Signature::GetFieldMDPAction ( )
    - CFX_WideStringArray foxit::pdf::Signature::GetFieldMDPActionFields ( )
    - void SetFieldMDPActionFields (const FieldMDPAction &action, const CFX_WideStringArray &field_array)
- New color methods for Graphic Objects: Color Space, Color State, CMYK/RGB Conversion and more
  - Related API/Class:
    - foxit::common::ColorSpace
    - foxit::pdf::graphics::ColorState
    - Color foxit::common::Color::ConvertToCMYK ( ColorSpace::RenderingIntent intent = ColorSpace::e_RenderIntentRelColorimetric ) const
    - Color foxit::common::Color::ConvertToRGB ( ColorSpace::RenderingIntent intent = ColorSpace::e_RenderIntentRelColorimetric ) const
- Added a new render flag: e_ColorModeMappingGray to map a color value according to a background color and a foreground color
  - Related API/Class:
    - foxit::common::Renderer::ColorMode
- Subset embedded fonts with a document to reduce the file size
  - Related API/Class:
    - static common::Progressive StartSubsetEmbedFont(const pdf::PDFDoc& doc, common::PauseCallback* pause);
- New methodfor retrieving a layer node dictionary
  - Related API/Class:
    - objects::PDFDictionary* foxit::pdf::LayerNode::GetDict()
- Additional options for Optimizer Add-on
  - Related API/Class:
    - foxit::addon::optimization::OptimizerSettings::DiscardObjectsOptions
    - foxit::addon::optimization::OptimizerSettings::DiscardUserDataOptions

#### Bug Fixed
- Invalid PDF/A after signing document issue fixed
- Bezier curve control points added to exported path object data
- Listbox font size changes correctly on zoom in/out activity
- Font embedding bugs fixed
- Fixed typo on: e_FlagChoiseMultiSelect to e_FlagChoiceMultiSelect
- Form object associated with layer node displays correct coordinates when rendered to page
- RectF.isEmpty() method always return true bug fixed

---

## Version 7.2.1
**Release Date**: April 13, 2020

Version 7.2.1 is a minor release

### Changes
- Separate Scan Add-on as a separate package.

---

## Version 7.2
**Release Date**: March 18, 2020

Version 7.2 is a minor release

### New Features
- Scanning Add-on Module
- New form fields supported on AcroForm designer at UI-level: RadioButton\ComboBox\ListBox
- Support "Save as" and "Reduce File Size" options on file save at UI-Level

### New Core Level Methods
- Support dynamically adding header and footer
- Enhancements to the optimization add-on
  - Support PDF document 'Clean Up' optimization settings
    - Remove invalid links
    - Remove invalid bookmarks
    - Use Flate to encode streams that are not encoded
    - Use Flate in streams that use LZW encoding
  - Support 'Discard Objects' optimization settings
    - Discard all form submission, import and reset actions
    - Flatten form fields
    - Discard all JavaScript actions
    - Discard embedded page thumbnails
    - Discard embedded print settings
    - Discard bookmarks
- Support loading certificates from stream/memory when using 'StartSign' method
- Support all angles for image rotation
- Support to set image to an XFA field
- New methods to get/set default appearance for widget annotation
- Support checking whether a rectangle object is adjacent to another in the horizontal or vertical direction
- Support to get a popup Annotation's parent
- Add rendering quality flag to image compression settings class

### Enhancements
- Deprecated UIWebView class migration to WKWebView
- Migrate PDF SDK for Android support library to AndroidX

### Plugin/Framework
- Xamarin Android/iOS plugin code update to VS 2019
- Foxit PDF SDK for iOS Flutter plugin release
- Synchronize update v7.2 for Xamarin/Cordova/React Native/Kotlin/Flutter

### Documentation
- Provide instructions on 'How to modify proguard file when minifyEnabled is set to true'

### Bug Fixes
- Fixed crash issue while trying to use a recycled bitmap
- Fixed crash issue related to "onDoubleTap"
- Fixes slow loading performance on large document issue for iOS
- Fixed typo errors for iOS
- Fixed missing color attribute when exporting redacted annotation to XFDF file
- Enhancements to the XFDF/FDFimport functionality - Updating annotation data when an identical annotation ID is found in the document
- Fixed PDFPage::GetBox failure on retrieving MediaBox data if the property is inherited from parent object
- Fixed bug on setValue method for Checkbox fields on specific files
- Fixed persistent access to redacted annotation content on specific files
- Fixed missing color space on tiff images added to PDF

---

## Version 7.1.0.1212
**Release Date**: December 16, 2019

Version 7.1 with hotfix. This is a maintenance release for iOS/Android

### Updated Core API to Foxit PDF SDK 7.1.0.1212 hotfix
- Remove ConnectedPDF Add-on
  - Related API/Class: foxit::addon::ConnectedPDF

### Others
- Remove 'Sign-in' feature at UI level
- Remove the APIs associated with ConnectedPDF add-on

---

## Version 7.1
**Release Date**: December 10, 2019

Version 7.1 is a minor release

### New Features
- New 'Save as' option
- iOS 13 Dark Mode
- New trusted certificates management feature for signatures at UI level

### Enhancements
- Settings for Text/Checkbox field styling at UI level
- Freeform rotation for Stamp annotation at UI level
- Support playing sound type annotation at UI level

### Bug Fixes
- Fixed pixelated rendering output of path objects and vectorized images in reflow mode
- Fixed crash issue when the page is zoomed to maximum capacity

---

## Version 7.0
**Release Date**: September 23, 2019

Version 7.0 is a major release

### New Features
- Support Long term validation of signatures (LTV)
- Support displaying list of digital signatures in the PDF document at UI level
- Support comparison of two PDF documents at UI level
- Support redaction of annotations at UI level
- Support form field creation at UI level - Text/CheckBox/Signature fields
- New UI layout and styling
- Support toolbar button to export or import annotation data

### Enhancements
- Support background color customization on reflow mode
- Support to get/set page navigation state for Android
- Enhancement on scaling and adaptation for PDFViewCtrl
- Support for double Page View Mode - iOS
- Support facing/cover continuous page modes at UI level
- Support progressive document loading on large size PDFs
- Support more search options at UI level - Case-Sensitive/Whole Words Only/Search in Internet
- Support adding blank Note/Callout/TextBox type annotations
- Support to get/set current UI language

### Documentation
- Provide 'How to change the localization settings' in the FAQ section of Developer Guide
- Provide 'How to reduce the size of APK' in the FAQ section of Developer Guide - Android

### Bug Fixes
- Form data loss when saving digital signatures bug fixed
- Fixed invalidLicense error when opening XFA PDF document with an XFA module license
- Fixed rendering bugs for specific files
- Fixed font issue on Android 9 devices

### Others
- Support output exception/stacktrace log within Foxit PDF SDK for Android

### Updated Core API to Foxit PDF SDK 7.0

#### New Features
- Support PAdES standard signature
  - Related Class: foxit.pdf.TimeStampServerMgr; foxit.pdf.TimeStampServer
  - Add signature filter/subfilter: (1) filter: Adobe.PPKLite subfilter: ETSI.CAdES.detached
- Support PDF 2.0 Long term validation of signatures (LTV)
  - Related Class: foxit::pdf::LTVVerifier; foxit.pdf.TimeStampServerMgr; foxit.pdf.TimeStampServer
  - Add signature filter/subfilter: (1) filter: Adobe.PPKLite subfilter: ETSI.RFC3161
- Additional Document/Annotation Javascript methods and properties supported

#### Enhancement
- Support Image/Path/Annotation/Shading comparison for PDF document
  - Related Class: foxit::addon::comparison
- Support NoZoom and NoRotate properties of annotation when rendering
  - foxit::pdf::annots::Annot::Flags:e_FlagNoZoom/e_FlagNoRotate
- Support to Get/Set more properties of redaction annotation
  - Related APIs: foxit::pdf::annots::Redact::SetQuadPoints; foxit::pdf::annots::Redact::GetQuadPoints; foxit::pdf::annots::Redact::GetOverlayText; foxit::pdf::annots::Redact::SetOverlayText; foxit::pdf::annots::Redact::GetOverlayTextAlignment; foxit::pdf::annots::Redact::SetOverlayTextAlignment; foxit::pdf::annots::Redact::GetDefaultAppearance; foxit::pdf::annots::Redact::SetDefaultAppearance
- Support to get/set border style of widget annotation
  - Related API: foxit::pdf::annots::Annot::SetBorderInfo
- Support to get/set appearance state of annotation
  - Related APIs: foxit::pdf::annots::Widget::GetAppearanceState; foxit::pdf::annots::Widget::SetAppearanceState
- Support to get name of appearance state 'ON' for annotation
  - Related API: foxit::pdf::annots::Widget::GetAppearanceOnStateName
- Custom method for verifying large files more efficiently
  - Related API: foxit.pdf.Signature.StartVerify
- Support opacity property for graphics objects
  - Related APIs: foxit::pdf::graphics::GraphicsObject::GetFillOpacity; foxit::pdf::graphics::GraphicsObject::SetFillOpacity; foxit::pdf::graphics::GraphicsObject::GetStrokeOpacity; foxit::pdf::graphics::GraphicsObject::SetStrokeOpacity
- Support to flatten XFA doc by using 'StreamCallback' callback class
  - Related API: foxit::addon::xfa::XFADoc::FlattenTo(foxit::common::file::StreamCallback* stream)
- Support to save the signed document by using 'StreamCallback' callback class
  - Related API: foxit::pdf::Signature::StartSign(..., foxit::common::file::StreamCallback* stream_callback, ...)
- Add width/height settings when getting the display matrix in reflow page mode
  - Related API: foxit::pdf::ReflowPage::GetDisplayMatrix(..., int width, int height, ...)
- Support to get/set quadrilaterals for redaction annotation
  - Related API: foxit::pdf::annots::Redact::GetQuadPoints; foxit::pdf::annots::Redact::SetQuadPoints
- Provide flag to set security data or password to be modified during encryption process
  - Related API: foxit::pdf::StdSecurityHandler::SetAES256ModifyFlags

#### Bug Fixes
- Fixes overlay issue when printing PDF page
- Fixes unknown error when using 'GetCharBBox' method
- Fixes crash issue when flattening specific PDF documents
- Fixes Type3 font issue
- Fixed memory overflow issues using the view demo
- Fixes display date issue when adding dynamic stamp
- Fixes invalid signature issue

---

## Version 6.4.0828
**Release Date**: August 28, 2019

Version 6.4 with hotfix. This is a maintenance release for iOS

### Bug Fixes
- Fixed issue where the fonts in the form text field cannot be displayed correctly for specific PDF document

---

## Version 6.4.0605
**Release Date**: June 05, 2019

Version 6.4 with hotfix. This is a maintenance release for Android

### Bug Fixes
- Fixed issue displaying characters due to font subset on Android 9 physical device

---

## Version 6.4
**Release Date**: May 28, 2019

Version 6.4 is a minor release

### New Features
- Support recognizing and adding signature to existing signature field of XFA form
- Support inserting new blank page(s) at UI/API level
- Support flattening single annotation at UI level
- Support selecting multiple annotations at UI level
- Page view rotation support at UI level

### Enhancements
- Support customizing the gap between two adjacent pages
- Support "ReadOnly" flag for annotation
- XFA form filling enhancement
- Full screen mode enhancement

### Documentation
- Provide detailed description of the UIExtensions project code

### Bug Fixes
- UI enhancements on content visibility for specific PDF files
- Fixed automatic form field toggling when using landscape mode for Android
- Fixed crash issue on android physical device when loading the PDF file from assets
- Fixed not visible annotation values (text fields) for specific PDFs

### Others
- Output exception/stacktrace logs within SDK for iOS

---

## Version 6.3.0417
**Release Date**: April 17, 2019

Version 6.3 with hotfix. This is a maintenance release for Android

### Bug Fixes
- Fixed crash issue when loading file from assets on specific physical device

---

## Version 6.3
**Release Date**: March 04, 2019

Version 6.3 is a minor release

### New Features
- Support cache storing when opening PDF file from URL
- Support two new paper viewing modes: FitWidth and FitPage at UI level

### Enhancements
- Support annotations immovable property
- New UI objects customization parameters added to 'uiextensions_config.json' file
- New classes/APIs/interfaces were exposed for external access in UIExtensions library
- Language localization support

### Documentation
- Additional tutorials in Developer Guide
- New Developer Guide section 'Customize feature modules and annotations through a configuration file'
- New Developer Guide section 'Implement Foxit PDF SDK for Android/iOS using React Native'
- New Developer Guide section 'Implement Foxit PDF SDK for Android/iOS using Cordova'
- New Developer Guide section 'Implement Foxit PDF SDK for Android/iOS using Xamarin'
- Some glitches were fixed and detailed descriptions were added to UIExtensions API in API Reference document

### Bug Fixes
- Fixes incorrect GoTo link location action
- Unexpected redraw cycles with rectangles displayed when using drawing tool on IPad

---

## Version 6.2.1.0116
**Release Date**: January 16, 2019

Version 6.2.1 with hotfix. This is a maintenance release for iOS

### Bug Fixes
- Fixed iOS testflight deployment bitcode issue

---

## Version 6.2.1
**Release Date**: December 07, 2018

Version 6.2.1 this is a minor release

### New Features
- RMS Extended Support at UI Level (iRMv1/iRMv2)

### Enhancements
- Implement Color Palette at UI Level - iOS
- UI elements default colors and color palette implemented across SDKs for consistency at UI Level

### Bug Fixes
- GotoPage() incorrect scrolling position issue
- Form filling incorrect behavior when using device predictive text/autocorrect
- Multiple form field reset for specific types of PDF
- Repeated clicks on '+' and '-' buttons crash the application in dynamic XFA
- Incomplete attachment panel menu after rotation in iPhone XS Max
- Dynamic XFA forms print settings not available on 'More' option

---

## Version 6.2
**Release Date**: November 09, 2018

Version 6.2. this is a minor release

### New Features
- Multimedia Annotations Support (Video&Sound) at UI level
- XFA Forms handling (Read & Fill) support at UI level

### Enhancements/Bug Fixes
- Event handler to catch selection/tapping on form field object (TextBox, ComboBox, CheckBox, PushButton, RadioButton, ListBox)
- Rendering performance enhancement for Android 6.1
- Fixes unexpected scrolling actions triggered by clicking a form field in continuous page mode for iOS
- Fixes full text search issue on iOS 12
- Fixes crash issue when duplicating a page multiple times

### Documentation
- Android - New function information added to the API reference document
  - Related API functions/Classes:
    - com.foxit.uiextensions.annots.AnnotEventListener
    - com.foxit.uiextensions.annots.AnnotHandler
    - com.foxit.uiextensions.pdfreader.ILifecycleEventListener
    - com.foxit.uiextensions.IPDFReader
    - com.foxit.uiextensions.IPDFReader.BackEventListener
    - com.foxit.uiextensions.pdfreader.IStateChangeListener
    - com.foxit.uiextensions.ToolHandler

### Others
- Support changing/reordering child layer nodes location in PDF

---

## Version 6.1.1.0831
**Release Date**: October 11, 2018

Version 6.1.1.0831 this is a maintenance release for iOS

### Bug Fixes
- Fixed RMS non-executable bundle error

---

## Version 6.1
**Release Date**: August 17, 2018

Version 6.1. this is a minor release

### New Plugins/Frameworks Support
- Cordova plugin: https://github.com/foxitsoftware/cordova-plugin-foxitpdf
- Kotlin support: https://github.com/foxitsoftware/kotlin-foxitpdf
- Xamarin support: https://github.com/foxitsoftware/xamarin-foxitpdf
- React Native: https://github.com/foxitsoftware/react-native-foxitpdf

### Enhancement/BugFixes
- Enhance the structure of UIExtensions
- Fix a crash issue (iOS) that fetch page before the page loading finish.
- Fix a issue that some inline images will be lost when edit a page of some specify PDF files.
- Fix a bug for iOS12

### Others
- Support X86-64 ABI for Android
- Change the output of iOS UIExtensions library from ".a" library to a framework, so that it can included resource directly
- Change the fsdk.jar to fsdk.arr and add the "*.so" to the fsdk.arr to enhance the users experience

### New features in PDF Core API 6.0
- Make a font as an embedded font
  - Related API: Font foxit::common::Font::Embed
- Added API function to delete an Associated file
  - Related API: void foxit::pdf::AssociatedFiles::RemoveAssociatedFile
- Provide default Signature handler
  - There is no new API specific function for this, but the current default security handler was improved. Currently, GSDK supports two types of signature filter/subfilter:
    - 1 filter: Adobe.PPKLite subfilter: adbe.pkcs7.detached
    - 2 filter: Adobe.PPKLite subfilter: adbe.pkcs7.sha1
  - If you uses one of them in their signature, they don't need to register a security validation code, the signature validation is in-built by default and will work automatically.
  - Essentially, this makes it very easy for users with less IT know-how to securely sign documents without having to develop a customized signature validation code.

### Enhancement/BugFixes at core API
- Improvement in the API reference
- Enhance the rendering with some special file
- Fix a signature verify issue (add a method called IsNeedPadData() to Signature callback)
- Fix a bug related to form fill feature

---

## Version 6.0.0.0626
**Release Date**: July 19, 2018

Version 6.0.0.0626. This is a maintenance release for Android

### Enhancement & Bug Fixes
- Fixes a Rendering issue with special documents.

---

## Version 6.0
**Release Date**: June 20, 2018

Version 6.0 is a major release.

### New Features/Enhancements for UI Extensions
- iPhone 8 and iPhone X Support
- Full Android 8.0 Support
- Callout Tool
- Polyline Tool
- RMS Support
- Connected PDF Support
- Mulit-Document Support Enhanced
- TextBox Tool Enhanced (can now resize TextBox after creation)
- Zoom Rate Feature Enhanced (Zoom In/Out can be set to any zoom rate)

### Update to PDF Core API
With the release of version 6.0, Foxit PDF SDK for iOS, Android and UWP now uses the same Core API as Foxit PDF SDK for Windows, Mac and Linux. This means that you can develop with a consistent API across all supported platforms and also that all functionality that was previously available on Windows, Mac and Linux is now supported in iOS, Android and UWP. The detailed list of new functionality available in the Core API with the release of version 6.0 is detailed below.

### New features in PDF Core API 6.0

#### High Level Improvements
- New support for XFA form fields
- PDF v2.0 support
- ConnectedPDF support
- Lifecycle management for page/document objects is now handled internally
- Consistent feature set and API across all platforms
- Includes all Foxit PDF SDK v5.0 features
- v6.0 has one standard package with four add-ons
- Indexed Full-Text Search support

#### Add-Ons
The Standard package includes many standard features such as PDF rendering, editing, annotating, AcroForm form fields, etc, and for specialized features there are currently four Add-Ons provided:

- XFA Add-on = foxit::addon::xfa
- Redaction Add-on = foxit::addon::Redaction
- ConnectedPDF Add-on: foxit::addon::ConnectedPDF
- RMS Add-on: foxit::pdf::RMSEncryptData, foxit::pdf::RMSSecurityCallback, foxit::pdf::RMSSecurityHandler

#### New Features

**Unencrypted wrapper document (PDF 2.0)**
- Unencrypted wrapper document is a new feature of PDF 2.0, in v6.0, Foxit PDF SDK support to save the PDF with this new feature.
- Related API = foxit::pdf::Doc::StartSaveAsPayloadFile

**256-bit AES encryption support (PDF 2.0)**
- Related API = foxit::pdf::SecurityHandler

**Associated Files (PDF 2.0)**
- In PDF 2.0, a new concept named "Associated files" is defined. Associated files provide a means to associate content in other formats with objects of a PDF file and identify the relationship between the content and the objects. Such associated files are designated using file specification dictionaries (known as file specification). Associated files could be linked to the PDF document's catalog, a page dictionary, graphics objects, structure elements, XObject, DParts, an annotation dictionary and so on. Specially, associated files with graphics objects means to be associated with the marked content item.
- Class AssociatedFiles is the class for managing associate files. It offers the functions to count/get associate files in PDF dictionary or graphics object, to associate files (represented by FileSpec) with catalog, PDF pages, graphics objects, form XObject objects, annotation objects and so on.
- Related API = foxit::pdf::AssociatedFiles cass

**XFA Add-On**
- XFA forms are XML-based forms, wrapped inside a PDF. It can be also used in PDF files starting with PDF 1.5 specification. XFA specification is referenced as an external specification indispensable for the application of ISO 32000-1 specification (PDF 1.7). XML Forms Architecture was not standardized as an ISO standard. XFA defines static forms (since XFA 2.0 and before) and dynamic forms (since XFA 2.1 or 2.2). In this version Foxit PDF SDK supports the filling of both static and dynamic XFA forms.
- Related API = foxit::addon::xfa

**ConnectedPDF Add-On**
- In Foxit PDF SDK 6.0 we have begun to make available some API's for adding ConnectedPDF functionality into third-party applications. Please contact sales@foxitsoftware.com if you are interested in trying the ConnectedPDF Add-On.

---

## Version 5.1.0.0109
**Release Date**: January, 2018

version 5.1.0.0109 this is a major release.

### New features for PDF Core API
- Enable/Disable Javascript for PDF
- Set the upper limit of PDF library cache size
- Some New APIs for FSFont Class
- New annotations Class/Method
- Form filed value/property setting API for Android
- RMS SecurityHandler for Android
- Some other APIs

### New Features for ViewCtrl
- Set Night Mode Color
- Open Doc from URL asynchronous
- Some other APIs

### New features for UI Extensions
- Pan and Zoom tool
- Text box Tool
- Polygon Tool
- Add Image as Annotation
- Snapshot Tool
- Distance Tool
- Cloud Tool
- Print Document
- Get the currently status of UI element (Show or Hide)

### New Demo
- Multi docs Demo

---

## Version 5.0.0.1107
**Release Date**: November 09, 2017

Version 5.0.0.1107 This is a maintenance release for iOS.

### Enhancement & Bug Fixes
- Updated Foxit MobilePDF SDK for iOS 11
- Resolved issue preventing projects which include RDK framework with bitcode enabled from being used in archives

---

## Version 5.0
**Release Date**: October 10, 2017

Version 5.0. This is a major release.

### New features for PDF Core API
- PDF watermark operation (add/edit/delete)
- Indexed Full-Text Search for Android (already supported in iOS)
- New e_saveFlagXRefStream option for "SaveAS" function
- New "SetDefaultContentsLength" method for Signature feature
- Third-Party Security Handler support
- Get page box information by box type (MediaBox, CropBox, TrimBox)
- Provide API to Access/Create an Image file (BMP, JPG, PNG, GIF, TIF, JPX, JBIG2)

### New features for UI Extensions
- Add/Remove buttons from/to the default UI so that the UI can be customized easily
- Show/Hide a special panel runtime (Reading Bookmarks/Outline/Annotations/Attachments Panel)
- Show/Hide the UI element in the view setting bar at runtime
- The type of annotations supported can be set by the configuration json file
- New event provided to allow developers to control what happens if the end user clicks on the "back" button
- New event provided for when end-user opens/taps on link
- Facing Mode support for Android (already supported in iOS)
- Support Relative Link and GoToR Action

### New features for View Control
- Add a new API to set whether to use tilling when refreshing page view (Android only)
- Added a method to append a view to current viewer control for Android

### Enhancement & Bug Fixes
- Fixes a rotation bug for iOS
- Other bug fixes

### Documentation
- Provide docset for iOS API reference so that users can integrate to Xcode
- API Reference includes the UI Extensions API's now

**Note:**
- There were some API changes from V4.0 to V5.0, for details please check the "Foxit MobilePDF SDK Upgrade Warnings.pdf" file in the doc folder
- There are some item/rules changes for json, for details please check the "Foxit MobilePDF SDK Upgrade Warnings.pdf" file in the doc folder

---

## Version 4.0
**Release Date**: July 06, 2017

Version 4.0. This is a major release.

### New features for PDF Core API
- Add and Verify Digital Signature from Third-Parties
- Add/Edit/Remove Optional Content Groups (Layers)
- Indexed Full-Text Search (iOS only)
- Add/Edit/Remove Document Level Attachments
- Get/Set PDF Version for a Document
- Set PDF Metadata for a Document

### New features for UI Extensions
- New Attachments Panel
- Duplicate Pages
- Add Image as a PDF Page
- Crop to Show Pages

### Improvement
- Configure UI Extensions using JSON files
- UI related source code moved from demo project to UI Extensions component
- Reading Bookmarks will remove if page they point to is deleted
- New special string table used in UI Extensions and Sample Code
- UI Extensions and sample code now use Apples's ARC (iOS only)

### Bug fixes
- Fixes multi-instance bug for iOS

### About Xamarin and Cordova
- Foxit provide Xamarin and Cordova plug-ins and samples provided on GitHub: https://github.com/foxitsoftware

---

## Version 3.0.0.0523
**Release Date**: June 05, 2017

Version 3.0.0.0523. This is a minor release for iOS

### Bug Fixes
- Fixed issues preventing acceptance by iOS App Store

---

## Version 3.0
**Release Date**: April 04, 2017

Version 3.0. This is a major release.

### New features for PDF Core API
- Insert and Extract Pages
- Import and Export Annotation through FDF/XFDF
- Import and Export Form Data through FDF/XFDF
- Certificate and Password Security
- Page Object Access and Edit
- Add Image to PDF files
- Pressure Sensitive Ink

### New features for View Control
- Append a custom page view to the end of the current document in the PDF View Control (iOS only)

### New features for UI Extensions
- Digital Signature Tool
- Hand Signature Tool
- Password Protect PDF Tool
- Doc Edit Mode (Insert, Extract, Delete and Reorder Pages)
- Attachment Tools (Annotation)
- Support Undo/Redo
- Reflow Text

### Demos
- Added complete_pdf_viewer demo for Swift

### Improvements
- **Form Filling Improvements:**
  - Automatically scrolls to the next form field when filling forms
  - List box enhanced for form filling
- Improved the Stamp Tools feature usability
- Android samples updated with the latest Gradle

---

## Version 2.0
**Release Date**: December 21, 2016

Version 2.0. This is a major release.

### New features at PDF Core level API
- Form Fill API with JavaScript support
- Flatten PDF
- Create/Edit Outlines
- Create/Edit Reading Bookmarks
- Import and Export Form Data via XML files
- Digital Signature support
- All Annotation Supported (same features as Foxit PDF SDK)

### New features for UI Extensions
- New Form Filling tool (with Javascript support)
- Text Markup Annotations (Replace Text, insert Text)
- Drawing Annotations (Line, Rectangle, Circle, Arrow, Pencil, Eraser)
- Typewriter tool
- Stamp tool (support for Standard Stamps, Sign Here Stamps and Dynamic Stamps)
- New Reading Bookmark Panel (bookmark a page while reading to record progress and interesting passages).

### Demos
- New Swift demo for iOS (ViewCtrl and Function Demo)
- Updated Complete Reader Demo with new features introduced in version 2.0
- Added Digital Signature feature sample to Functions demo

### Enhancements and bug fixes
- Support added to set the fill color of an annotation as no color (Remove Property) [Core API]
- Optimized the UX for the complete_pdf_viewer demo's text selection functionality
- Support added for URL type Annotation Link at UI Extension level - feature missing in iOS RDK V1.0

---

## Version 1.0
**Release Date**: October 04, 2016

This is the first release of Foxit PDF SDK, it is a new Rapid Development Kit for mobile platforms which focuses on helping developers rapidly integrate powerful Foxit PDF technology into their own apps. With Foxit Mobile PDF SDK, even developers with a limited knowledge of PDF can quickly realize a PDF Viewer with just a few lines of codes. Now, it is available on iOS and Android platforms.

Foxit PDF SDK provides a Java API for Android and an Objective-C API for iOS and consists of three feature elements:

### PDF Core API
The Core API contains all of the non-viewer level functions for Foxit PDF SDK.

### View Control
The View Control is a utility class for creating the base viewer for displaying PDFs.

### UI Extensions Component
The UI Extensions Component provides ready-made UI and features which can be customized. Outline Panel (Show Outline) aka Bookmarks

Please refer to the getting_started_android.pdf/getting_started_iOS.pdf document in the same folder as this file for additional information.
