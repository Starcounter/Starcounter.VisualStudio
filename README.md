# Starcounter Visual Studio.

A Visual Studio extension that assist in development and debugging of Starcounter applications. Contain project- and item templates and support the extension to be installed and uninstalled using a VSIX package.

## Releasing a new version

### Build

* Clone the [source repository](https://github.com/Starcounter/Starcounter.VisualStudio) from Github. 
    * On the command line, enter:
    ````
    git clone https://github.com/Starcounter/Starcounter.VisualStudio.git
    ````
* Open `src\Starcounter.VisualStudio.sln`.
* Expand the project `Starcounter.VS.VSIX` and open file `source.extension.vsixmanifest`.
* Change the version number to the version number that you want to release. e.g. `1.0.x`
* Change the build type to `Release` and build the `Solution`.

### Testing

* Open the directory `bin\Release\`
* Run `Starcounter.VS.vsix`.
* Make sure this successfully installs the project extension.

### Pack

* Open the file `build\version.txt`.
* Enter the version that you want to release e.g. `1.0.X`.
* Open the command line in the `Starcounter.VisualStudio` and enter:
	```
	pushd build
	```
* Execute the batch file `pack.bat` by entering:
	```
	.\pack.bat
	```
* This should create a directory in `Starcounter.VisualStudio\artifacts`

### Publishing to nuget.org
* Download the latest [Nuget.exe](https://www.nuget.org/downloads) from Nuget.org.
* Enter the following command:  
	```
	set PATH=%PATH%;C:\nuget 
	```
	where "c:\nuget" is the path to the nuget.exe.
* You would need `StarcounterNuGetKeyFull` in order to publish, ask for the Key to `UrbanStar` team.
* Enter command:
	```
	set StarcounterNuGetKeyFull="xxxx"
	```
* Enter following command to publish :
	```
	.\pack_and_push.bat
	```
* New version should appear in  [Package Home](https://www.nuget.org/packages/Starcounter.VisualStudio/) after some time.

### Updating extension in `VS Marketplace`

*	Login to [Visual Studio Marketplace] (https://marketplace.visualstudio.com). Please ask to `UrbanStar` team if you don't have the credentials.
*	Search for `Starcounter`.
*	Browse `Starcounter for Visual Studio`.
*	Click on the `Manage` link at the top right corner.
*	Click on the Kebab Menu `(...)` found in front of the extension name and choose `Edit`.
* 	In the `Upload extension` section click on the `pencil icon` and choose the `Starcounter.VS.vsix` file found under the directory `bin\Release\`.
	The the version number that you want to upload should appear in the `version number` field on the same window.
*	Click on the `Save & upload` button found at the bottom of the window.


# Resources
* Home on [Visual Studio marketplace]( https://marketplace.visualstudio.com/items?itemName=Starcounter.StarcounterforVisualStudio).
* Home for package on [nuget.org](https://www.nuget.org/packages/Starcounter.VisualStudio/).

