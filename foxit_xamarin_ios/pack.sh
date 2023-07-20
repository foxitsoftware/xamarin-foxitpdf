#!/bin/sh
basepath=$(cd `dirname $0`; pwd)

zip_frameworks(){
  cd ${basepath}/libs
  zip -q -r $1.zip $1
}

pack_lib(){
    dotnet clean $1
    dotnet restore $1
    rm -rf $1/bin
    rm -rf $1/obj
    
    dotnet pack -c Release $1/$2.csproj -p:NuspecFile=${basepath}/nuspec/$2.nuspec
    mv $1/bin/Release/$2*.nupkg ./nupkg/

}

PWD=`pwd`

cd ${basepath}

if [ ! -d "${basepath}/nupkg" ]; then
    mkdir nupkg
fi

zip_frameworks FoxitRDK.xcframework

zip_frameworks uiextensionsDynamic.xcframework

zip_frameworks FoxitPDFScanUI.framework

pack_lib ${basepath}/Foxit.iOS/Foxit.iOS  Foxit.iOS

pack_lib ${basepath}/Foxit.iOS.UIExtensions/Foxit.iOS.UIExtensions  Foxit.iOS.UIExtensions

pack_lib ${basepath}/Foxit.iOS.Scanning.UI/Foxit.iOS.Scanning.UI  Foxit.iOS.Scanning.UI

cd ${PWD}
