cd /d %~dp0
cd /d ..\src\Fischless.Logger
dotnet restore
dotnet build -c Release
dotnet pack -c Release -o ../../build/
cd /d %~dp0
@pause
