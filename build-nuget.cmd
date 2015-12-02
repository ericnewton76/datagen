REM On AppVeyor, This build script must be run "AFTER BUILD" and BEFORE TESTS because AppVeyor's artifacts gathering happens right then.
REM The Nuget deployment relies on ARTIFACTS not files within the build tree.

@ECHO OFF
setlocal

REM initialization
set NUGET_EXE=nuget.exe 

REM appveyor
if not "%APPVEYOR_BUILD_VERSION%" == "" set BUILD_VERSION=%APPVEYOR_BUILD_VERSION%
if not "%APPVEYOR_BUILD_VERSION%" == "" set NUGET_EXE=nuget

REM checks
echo %NUGET_EXE%
if "%BUILD_VERSION%" == "" echo Missing BUILD_VERSION & goto :END

if "%1" == "--after-build" goto :SKIP_BUILD

echo.
if "%1" == "--no-msbuild" goto :SKIP_BUILD
call .\build.cmd & if errorlevel 1 goto :END
shift

:SKIP_BUILD

REM Create Nuget Package
echo %NUGET_EXE% pack %APPYVEYOR_PROJECT_NAME%.nuspec -version %BUILD_VERSION%
%NUGET_EXE% pack %APPYVEYOR_PROJECT_NAME%.nuspec -version %BUILD_VERSION%

REM if not "%1" == "--no-deploy" %NUGET_EXE% push
shift

:END