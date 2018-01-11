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
* Change the build type to `Release` and build the `Solution`.

### Testing

* Open the directory `bin\Release\`
* Run `Starcounter.VS.vsix`.
* Make sure this successfully install the project extension.

### Pack

* Open the file `build\version.txt`.
* Change the text with the version number you want to release e.g. `v2.0.1`.
* Open the command line in the `Starcounter.VisualStudio` and enter:
	```
	pushd build
	```
* Execute the batch file `build.bat` by entering:
	```
	.\build.bat
	```
* This should create a directory in `Starcounter.VisualStudio\artifacts`

### Publishing to nuget.org

* You would need `StarcounterNuGetKeyFull` in order to publish, ask for the Key to `Urban-star` team.
* Edit `build\pack_and_push.bat` in notepad.
* Set key in the file by `set StarcounterNuGetKeyFull=XXXXXXX `
* Enter following command to publish :
	```
	.\pack_and_push.bat
	```
* New version should apear in  [Package Home](https://www.nuget.org/packages/Starcounter.VisualStudio/) after some time.

# Resources
* Home on [Visual Studio marketplace]( https://marketplace.visualstudio.com/items?itemName=Starcounter.StarcounterforVisualStudio).
* Home for package on [nuget.org](https://www.nuget.org/packages/Starcounter.VisualStudio/).

