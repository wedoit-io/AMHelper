echo "Hai portato avanti la versione ?"
pause
cd ..
copy .\readme.txt .\bin
.\nuget\NuGet.exe pack .\nuget\AMHelper.nuspec -basepath bin -o .\nuget\