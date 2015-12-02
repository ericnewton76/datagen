@ECHO OFF
setlocal
set PROJECT_NAME=datagen

if not "%APPVEYOR_PROJECT_NAME%" == "" set PROJECT_NAME=%APPVEYOR_PROJECT_NAME%

msbuild src\%PROJECT_NAME%.sln /p:OutputPath=..\..\Build\%PROJECT_NAME%
REM msbuild src\%PROJECT_NAME%\%PROJECT_NAME%.csproj /p:OutputPath=..\..\Build\%PROJECT_NAME%