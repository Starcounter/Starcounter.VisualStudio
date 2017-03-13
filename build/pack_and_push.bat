@echo off

set /p PackVersion=<version.txt
set OutDir=..\artifacts
set PackagePath=%OutDir%\Starcounter.VisualStudio.%PackVersion%.nupkg
set VSIXFile=..\bin\Release\Starcounter.VS.vsix

:: Make sure content is there, to know we don't produce an empty one
IF NOT EXIST "%VSIXFile%" (
	ECHO File not found: %VSIXFile%
	EXIT /b 991
)

:: We need an API key to push
IF "%StarcounterNuGetKeyFull%"=="" (
	ECHO StarcounterNuGetKeyFull is not set
	EXIT /b 990
)

nuget pack -OutputDirectory ..\artifacts -Version %PackVersion% Starcounter.VisualStudio.nuspec
IF ERRORLEVEL 1 GOTO FAILED

:: Assure we have a predictable result to push
IF NOT EXIST "%PackagePath%" (
	EXHO File not found: %PackagePath%
	EXIT /b 991
)

nuget push %PackagePath% %StarcounterNuGetKeyFull% -source https://www.nuget.org
IF ERRORLEVEL 1 GOTO FAILED

:SUCCESS
SET EXITCODE=0
GOTO FINALLY

:FAILED
SET EXITCODE=%ERRORLEVEL%
ECHO Exiting script with error code %EXITCODE%

:FINALLY
EXIT /b %EXITCODE%