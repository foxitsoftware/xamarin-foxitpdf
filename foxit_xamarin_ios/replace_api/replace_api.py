# -- coding: utf-8 --
import re
import os,shutil

def stringByAppendingCopyright(codefile):
    copyright='\
/**\n\
* Copyright (C) 2003-2021, Foxit Software Inc..\n\
* All Rights Reserved.\n\
*\n\
* http://www.foxitsoftware.com\n\
*\n\
* The following code is copyrighted and is the proprietary of Foxit Software Inc.. It is not allowed to\n\
* distribute any parts of Foxit PDF SDK for iOS to third party or public without permission unless an agreement\n\
* is signed between Foxit Software Inc. and customers to explicitly grant customers permissions.\n\
* Review legal.txt for additional license and legal information.\n\
*/\n\n'
    return copyright+codefile

def replace_file_string(srcPath,scrStr,replaceStr,replace=False):

    old_file=srcPath
    fopen=open(old_file,'r')

    w_str=""
    if replaceStr=='StructsAppending' or replaceStr=='ApiDefinitionAppending':
        appendingopen=open('./'+replaceStr,'r')
        try:
            appendingStr = appendingopen.read()
            appendingopen.close()
        finally:
            appendingopen.close()
        if len(appendingStr)>0:
            if replaceStr=='ApiDefinitionAppending':
                w_str=fopen.read()
                rule=r'(?=}).+?(?=// @interface UIExtensionsConfig : NSObject)' #The last object transformation
                last_codes=re.findall(rule,w_str,re.S)
                if len(last_codes)==1:
                    appending_code=last_codes[0]+appendingStr+'\n'
                    w_str=re.sub(rule, appending_code, w_str, 0, re.S)
            else:
                flagCout=0
                for line in fopen:
                    if re.search('}\n',line):
                        flagCout+=1
                        if flagCout==2:
                            line=re.sub('}\n',appendingStr+'\n}',line)
                            w_str+=line
                        else:
                            w_str+=line
                    else:
                        flagCout=0
                        w_str+=line
    else:
        for line in fopen:
            if re.search(scrStr,line):
                line=re.sub(scrStr,replaceStr,line)
                w_str+=line
            else:
                w_str+=line
    if replace == True:
        w_str = w_str.replace(scrStr, replaceStr)
    wopen=open(old_file,'w')
    wopen.write(w_str)
    fopen.close()
    wopen.close()
    return w_str

def replace_api_definitions_Iprotocol(srcPath,foxitrdk):
    foxitrdk_Iprotocols = ['IIGestureEventListener', 'IIDrawEventListener', 'IITouchEventListener', 'IConnectedPDFDelegate', 
    'IIRotationEventListener', 'IFSPageOrganizerDelegate', 'IFSFileReaderCallback', 'IFSSecurityCallback', 
    'IFSRMSSecurityCallback', 'IFSCustomSecurityCallback']
    foxitrdk_uiextensions_Iprotocols=['IIAppLifecycleListener','IIAnnotEventListener','IILinkEventListener', 'IMoreItemProtocol', 'IIModule', 'IIToolEventListener', 'IISignatureEventListener','IIUIInteractionEventListener']

    fopen=open(srcPath,'r')
    try:
        fopenStr = fopen.read()
        fopen.close()
    finally:
        fopen.close()
    if len(fopenStr)>0:
        if foxitrdk==True:
            for Iprotocol in foxitrdk_Iprotocols:
                if re.search(Iprotocol,fopenStr):
                    replace_Iprotocol=Iprotocol[1:]
                    fopenStr=re.sub(Iprotocol, replace_Iprotocol, fopenStr)
        else:
            for Iprotocol in foxitrdk_uiextensions_Iprotocols:
                if re.search(Iprotocol,fopenStr):
                    replace_Iprotocol=Iprotocol[1:]
                    fopenStr=re.sub(Iprotocol, replace_Iprotocol, fopenStr)        

        sub_callbacks = ['FSRMSSecurityCallback','FSCustomSecurityCallback']
        for sub_callback in sub_callbacks:
            start_index_str='// @protocol '+sub_callback
            end_index_str='interface '+sub_callback +' :'
            search_rules_compile=re.compile(r'(?=%s).+?(?=%s)'%(start_index_str,end_index_str),re.S)
            search_results=search_rules_compile.findall(fopenStr)
            if len(search_results)==1:
                append_code=search_results[0]+'[BaseType(typeof(NSObject))]\n\t'
                fopenStr=search_rules_compile.sub(append_code,fopenStr,0)
    wopen=open(srcPath,'w')
    wopen.write(fopenStr)
    wopen.close()


def replace_api_protocols_for_obj_find(srcPath):
    fopen=open(srcPath,'r')
    protocols = []
    for line in fopen:
        if "// @protocol" in line:
            protocol_line = line.replace('// @protocol', '')
            protocol_line_break = protocol_line.split( )
            protocol = ''
            for protocol_str in protocol_line_break:
                protocol = protocol_str.strip()
                if len(protocol) > 0:
                    break
            protocols.append(protocol)
    fopen.close()

    for protocol in protocols:
        w_str=""
        fopen=open(srcPath,'r')
        replace_protocol_str = protocol + ' '
        for line in fopen:
            if "// @protocol" not in line and "interface" not in line and replace_protocol_str in line:
                line = line.replace(replace_protocol_str, 'NSObject ')
            w_str+=line 
        wopen=open(srcPath,'w')
        wopen.write(w_str)
        wopen.close()


def replace_api_definitions_comment_codes(codes_str,codes):
    new_codes_str=codes_str
    for code in codes:       
        comment_codes=re.findall(code,new_codes_str,re.S)
        if len(comment_codes)==1:
            comment_code='/*\n\t\t'+comment_codes[0]+'\n\t\t*/'
            if re.search(code,new_codes_str,re.S):
                new_codes_str=re.sub(code, comment_code, new_codes_str, 0, re.S)
    return new_codes_str

def comment_useless_codes(srcPath):

    # 将需要注释的代码放在数组，如果多个类存在相同的方法名，重新创建一个数组在，在创建的数组中添加你需要注释的代码，内部的注释第一个元素是需要注释的代码的类
    useless_codes=[
        r'(?=// @required -\(FSClientInfo).+?(?<=Info { get; })',
            [
                r'(?=// @interface RMSProtection :).+?(?<=int PdfPermissionFromUserPolicy { get; })',r'(?=// -\(BOOL\)isOwner;).+?(?<=permissions\);)',
                r'(?=// @property \(nonatomic, strong\) MSUserPolicy \* userPolicy).+?(?<=MSUserPolicy UserPolicy { get; set; })',
                r'(?=// @property \(nonatomic, strong\) MSConsentManager \* consentManager).+?(?<=MSConsentManager ConsentManager { get; set; })'
            ],
        r'(?<=void SetExceptionLogger \(\[NullAllowed\] FSExceptionLoggerDelegate logger\);).+?(?<={)',
        r'(?<=bool ReloadXFADoc \(FSDocProviderCallbackPageViewEventType page_view_event_type, NSNumber\[\] pageIndexes\);).+?(?<={)',
        r'(?=// extern const unsigned char\[\] uiextensionsDynamicVersionString).+?(?<=uiextensionsDynamicVersionString { get; })',
        r'(?=// @property \(nonatomic, strong\) BlockButton \* _Nonnull signBtn;).+?(?<=BlockButton SignBtn { get; set; })',
        r'(?=// extern const unsigned char\[\] FoxitPDFScanUIVersionString).+?(?<=FoxitPDFScanUIVersionString { get; })',
        r'(?<=void UpdateBtnLayout \(\);\n	}).+?(?<=\[Static\])',
        ]

    fopen=open(srcPath,'r')
    try:
        fopenStr = fopen.read()
        fopen.close()
    finally:
        fopen.close()
    if len(fopenStr)>0:
        for useless_code in useless_codes:
            if isinstance(useless_code, str):
                fopenStr=replace_api_definitions_comment_codes(fopenStr,[useless_code])
            if isinstance(useless_code, list):
                if len(useless_code)>1:
                    class_file_strs=re.findall(useless_code[0],fopenStr,re.S)
                    if len(class_file_strs)==1:
                        class_file_str=class_file_strs[0]
                        codes=list(useless_code)
                        del codes[0]
                        class_file_str=replace_api_definitions_comment_codes(class_file_str,codes)
                        fopenStr=re.sub(useless_code[0], class_file_str, fopenStr, 0, re.S)
    wopen=open(srcPath,'w')
    wopen.write(fopenStr)
    wopen.close()

def replace_api_definitions(srcPath,destPath,foxitrdk = False):

    replace_copy_file(srcPath,destPath)

    # if foxitrdk==False:
    #     replace_file_string(destPath,'','ApiDefinitionAppending')

    replace_api_definitions_Iprotocol(destPath,foxitrdk)
    comment_useless_codes(destPath)

    replace_file_string(destPath,'CGContextRef\*','IntPtr')
    replace_file_string(destPath,'unsafe void\*','IntPtr')
    replace_file_string(destPath,'void\*','IntPtr')
    replace_file_string(destPath,'int\*','int')
    replace_file_string(destPath,'float\*','float')
    replace_file_string(destPath,'NSURL','NSUrl')
    replace_file_string(destPath,'NativeHandle','IntPtr')
    replace_file_string(destPath,'unsafe IntPtr Constructor','IntPtr Constructor')
    replace_file_string(destPath,'dispatch_block_t', 'Action')
    replace_file_string(destPath,'NSData Size \(ulong offset, ulong size\)', 'NSData readBlock (ulong offset, ulong size)')
    replace_file_string(destPath,'void SettingBar \(SettingBar settingBar, bool isNightMode\)','void SettingBarSetNightMode (SettingBar settingBar, bool isNightMode)')
    replace_file_string(destPath,'FSPDFUIExtensionsManager ExtensionsManager', 'NSObject ExtensionsManager')
    replace_file_string(destPath,r'(?=NSMutableArray\<).+?(?<=\>)','NSMutableArray')
    replace_file_string(destPath,r'(?=NSSet\<).+?(?<=\>)','NSSet<NSObject>')
    replace_file_string(destPath,'void SettingBar \(FSSettingBar settingBar, bool isLockScreen\)','void SettingBarLockScreen (FSSettingBar settingBar, bool isLockScreen)')
    replace_file_string(destPath,'void SettingBar \(FSSettingBar settingBar, bool isNightMode\)','void SettingBarNightMode (FSSettingBar settingBar, bool isNightMode)')
    replace_file_string(destPath,'''		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group beforeGroup:(FSMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:beforeGroup:forMenuViewType:")]
		void InsertMenuItemGroup (FSMenuItemGroup group, FSMenuItemGroup siblingGroup, FSMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group afterGroup:(FSMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:afterGroup:forMenuViewType:")]
		void InsertMenuItemGroup (FSMenuItemGroup group, FSMenuItemGroup siblingGroup, FSMenuViewType menuViewType);''','''		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group beforeGroup:(FSMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:beforeGroup:forMenuViewType:")]
		void InsertMenuItemGroupBefore (FSMenuItemGroup group, FSMenuItemGroup siblingGroup, FSMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group afterGroup:(FSMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:afterGroup:forMenuViewType:")]
		void InsertMenuItemGroupAfter (FSMenuItemGroup group, FSMenuItemGroup siblingGroup, FSMenuViewType menuViewType);''', True)
    replace_file_string(destPath,'''		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group beforeGroup:(PDFScanMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:beforeGroup:forMenuViewType:")]
		void InsertMenuItemGroup (PDFScanMenuItemGroup group, PDFScanMenuItemGroup siblingGroup, PDFScanMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group afterGroup:(PDFScanMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:afterGroup:forMenuViewType:")]
		void InsertMenuItemGroup (PDFScanMenuItemGroup group, PDFScanMenuItemGroup siblingGroup, PDFScanMenuViewType menuViewType);''','''		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group beforeGroup:(PDFScanMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:beforeGroup:forMenuViewType:")]
		void InsertMenuItemGroupBefore (PDFScanMenuItemGroup group, PDFScanMenuItemGroup siblingGroup, PDFScanMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group afterGroup:(PDFScanMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:afterGroup:forMenuViewType:")]
		void InsertMenuItemGroupAfter (PDFScanMenuItemGroup group, PDFScanMenuItemGroup siblingGroup, PDFScanMenuViewType menuViewType);''', True)

    replace_file_string(destPath,'''	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/''','    ', True)
    replace_file_string(destPath,'\[Protocol\]','[Protocol, Model]', True)
    replace_file_string(destPath,'(.*\[Protocol.*\(AutoGeneratedName.*\)\])','''#if !NET
    [Protocol, Model]		
#endif''', True)
    replace_file_string(destPath,'using FoxitRDK;\n','')
    replace_file_string(destPath,'using uiextensionsDynamic;\n','')
    replace_file_string(destPath,'using FoxitPDFScanUI;\n','')
    replace_file_string(destPath,'namespace Foxit.iOS.Scanning.UI\n','using Foxit.iOS;\nusing Foxit.iOS.UIExtensions;\n\nnamespace Foxit.iOS.Scanning.UI\n')
    replace_file_string(destPath,': IFSPDFMultipleScenes','')
    replace_file_string(destPath,r'(.*\[iOS.*\(13.*\)\])','''#if !NET
    [iOS (13, 0)]
#endif''')

    replace_api_protocols_for_obj_find(destPath)

    w_str= stringByAppendingCopyright(replace_file_string(destPath,'\[Verify', '//[Verify'))

    wopen=open(destPath,'w')
    wopen.write(w_str)
    wopen.close()

def replace_structs(srcPath,destPath,foxitrdk = False):
    if not os.path.exists(srcPath):
        return
    
    replace_copy_file(srcPath,destPath)

    if foxitrdk==True:
        replace_file_string(destPath,'','StructsAppending')

    replace_file_string(destPath,'using FoxitRDK;\n','')
    replace_file_string(destPath,'using uiextensionsDynamic;\n','')

    replace_file_string(destPath,'\[Native\]','//[Native]')
    replace_file_string(destPath,': uint','')
    replace_file_string(destPath,': nuint','')

    w_str= stringByAppendingCopyright(replace_file_string(destPath,': nint',''))
    
    
    wopen=open(destPath,'w')
    wopen.write(w_str)
    wopen.close()

def replace_copy_file(srcfile,dstfile):
    if not os.path.isfile(srcfile):
        print ("%s not exist!"%(srcfile))
    else:
        fpath,fname=os.path.split(dstfile)
        if not os.path.exists(fpath):
            os.makedirs(fpath)
        shutil.copyfile(srcfile,dstfile)
        print ("copy %s -> %s"%( srcfile,dstfile))

def main():
    #replace begin
    print("Replace begin...")
    
    libs_path = os.environ.get('libs_path')
    replace_api_path = os.environ.get('replace_api_path')
    
    replace_api_definitions( libs_path + '/bind/FoxitRDK/ApiDefinitions.cs', libs_path +'/../Foxit.iOS/Foxit.iOS/ApiDefinition.cs',True)
    replace_structs(libs_path + '/bind/FoxitRDK/StructsAndEnums.cs',libs_path + '/../Foxit.iOS/Foxit.iOS/Structs.cs',True)
    
    replace_api_definitions( libs_path + '/bind/uiextensionsDynamic/ApiDefinitions.cs', libs_path + '/../Foxit.iOS.UIExtensions/Foxit.iOS.UIExtensions/ApiDefinition.cs')
    replace_structs( libs_path + '/bind/uiextensionsDynamic/StructsAndEnums.cs', libs_path + '/../Foxit.iOS.UIExtensions/Foxit.iOS.UIExtensions/Structs.cs')

    replace_api_definitions( libs_path + '/bind/FoxitPDFScanUI/ApiDefinitions.cs', libs_path + '/../Foxit.iOS.Scanning.UI/Foxit.iOS.Scanning.UI/ApiDefinition.cs')
    replace_structs( libs_path + '/bind/FoxitPDFScanUI/StructsAndEnums.cs', libs_path + '/../Foxit.iOS.Scanning.UI/Foxit.iOS.Scanning.UI/Structs.cs')

    print("Replace end.")

if __name__=='__main__':
    main()
