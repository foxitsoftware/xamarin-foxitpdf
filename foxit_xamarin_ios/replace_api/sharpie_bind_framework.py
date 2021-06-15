import os

def sharpie_bind(bind_name,namespace,sdk_version):
    assert os.system(r'sharpie bind --output=./bind/' +  bind_name + r' --namespace=' + namespace + r' -framework ./' + bind_name + r'.framework -sdk iphoneos'+sdk_version) == 0


def main():

    current_path=os.getcwd()
    libs_path=current_path+r'/../libs'
    os.chdir(libs_path)
    sdk_version='14.5'
    sharpie_bind('FoxitRDK','Foxit.iOS',sdk_version)
    sharpie_bind('uiextensionsDynamic','Foxit.iOS.UIExtensions',sdk_version)
    sharpie_bind('FoxitPDFScanUI','Foxit.iOS.Scanning.UI',sdk_version)

    relace_api_path=r'./../replace_api'
    os.chdir(relace_api_path)
     
    os.environ['libs_path']=libs_path
    os.environ['replace_api_path']=current_path

    os.system(r'python replace_api.py')
     

if __name__=='__main__':
    main()
