@echo off

set /p PackVersion=<version.txt
set OutDir=..\artifacts
set VSIXFile=..\bin\Release\Starcounter.VS.vsix

:: Make sure content is there, to know we don't produce an empty one
IF NOT EXIST "%VSIXFile%" (
	ECHO File not found: %VSIXFile%
	EXIT /b 991
)

nuget pack -OutputDirectory %OutDir% -Version %PackVersion% Starcounter.VisualStudio.nuspec