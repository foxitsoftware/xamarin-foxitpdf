#!/bin/sh
basepath=$(cd `dirname $0`; pwd)

framework_to_xcfamework(){
  cd ${basepath}/libs

  rm -rf ./iphoneos

  rm -rf ./iphonesimulator

  rm -rf ./$1.xcframework

  mkdir -p iphoneos && cp -rf $1.framework ./iphoneos/$1.framework
  mkdir -p iphonesimulator && cp -rf $1.framework ./iphonesimulator/$1.framework
  
  xcrun lipo -remove x86_64 ./iphoneos/$1.framework/$1 -o ./iphoneos/$1.framework/$1
  xcrun lipo -remove arm64 ./iphonesimulator/$1.framework/$1 -o ./iphonesimulator/$1.framework/$1
  
  xcodebuild -create-xcframework -framework ./iphoneos/$1.framework -framework ./iphonesimulator/$1.framework -output $1.xcframework

}

tar_frameworks(){
  cd ${basepath}/libs
  tar -czvf $1.tar $1
}

pack_lib(){
    dotnet clean $1
    dotnet restore $1
    rm -rf $1/bin
    rm -rf $1/obj
    
    dotnet pack -c Release $1/$2.csproj -p:NuspecFile=${basepath}/nuspec/$2.nuspec
    mv $1/bin/Release/$2*.nupkg ${basepath}/nupkg/
}

PWD=`pwd`

cd ${basepath}

rm -rf ./nupkg/
mkdir nupkg

framework_to_xcfamework FoxitPDFScanUI

tar_frameworks FoxitRDK.xcframework

tar_frameworks uiextensionsDynamic.xcframework

tar_frameworks FoxitPDFScanUI.xcframework

pack_lib ${basepath}/Foxit.iOS/Foxit.iOS  Foxit.iOS

pack_lib ${basepath}/Foxit.iOS.UIExtensions/Foxit.iOS.UIExtensions  Foxit.iOS.UIExtensions

pack_lib ${basepath}/Foxit.iOS.Scanning.UI/Foxit.iOS.Scanning.UI  Foxit.iOS.Scanning.UI

cd ${PWD}
