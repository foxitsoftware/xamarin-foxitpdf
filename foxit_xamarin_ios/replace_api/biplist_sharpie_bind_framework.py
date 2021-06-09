import os
import sys
import subprocess
from biplist import *

scripts_path = os.path.split(os.path.realpath(sys.argv[0]))[0]
sdk_version = '14.3'

def framework_namespace_dict():
    return {'FoxitRDK': 'Foxit.iOS', 'uiextensionsDynamic': 'Foxit.iOS.UIExtensions', 'FoxitPDFScanUI': 'Foxit.iOS.Scanning.UI'}

def replace_plist(framework_name):
    plist_path = framework_name + '.framework/info.plist'
    try:
        plist = readPlist(plist_path)
        for key in plist:
            if key == 'DTPlatformVersion':
                plist[key] = sdk_version
            if key == 'DTSDKName':
                plist[key] = 'iphoneos' + sdk_version
            writePlist(plist, plist_path)
        # print plist
    except (InvalidPlistException, NotBinaryPlistException), e:
        print "Not a plist:", e
        
def get_xcodebuild_showsdks_version():
    version = sdk_version
    res = subprocess.Popen('xcodebuild -showsdks',shell=True,stdout=subprocess.PIPE,stderr=subprocess.PIPE,close_fds=True)
    result = res.stdout.readlines()
    tag = 'iphoneos'
    for line in result:
        if line.find(tag) != -1:
            index = line.index(tag)
            v = line[(index + len(tag)):]
            if float(v) > 12:
                version = str(float(v))
            break
    return version

def sharpie_bind(bind_name,namespace,sdk_version):
    assert os.system(r'sharpie bind --output=./bind/' +  bind_name + r' --namespace=' + namespace + r' -framework ./' + bind_name + r'.framework -sdk iphoneos'+sdk_version) == 0

def main():

    libs_path = scripts_path + r'/../libs'
    os.chdir(libs_path)

    global sdk_version
    sdk_version = get_xcodebuild_showsdks_version()
    print 'ios sdk version:' + sdk_version

    framework_namespaces = framework_namespace_dict()
    for framework_name in framework_namespaces:
        replace_plist(framework_name)
        sharpie_bind(framework_name,framework_namespaces[framework_name],sdk_version)

    relace_api_path = scripts_path
    os.chdir(relace_api_path)
     
    os.environ['libs_path'] = libs_path
    os.environ['replace_api_path'] = scripts_path

    os.system(r'python ' + scripts_path + '/replace_api.py')
     

if __name__=='__main__':
    main()
