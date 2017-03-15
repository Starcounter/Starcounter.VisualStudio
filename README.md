# Starcounter Visual Studio development assist

A Visual Studio extension that assist in development and debugging of Starcounter applications. Contain project- and item templates and support the extension to be installed and uninstalled using a VSIX package.

# Build
Build `src\Starcounter.VisualStudio.sln`.

# Install / uninstall locally
After building, go to `bin\[Configuration]\`. Double-click `Starcounter.VS.vsix`.

# Pack
The package version is maintained in `build\version.txt`.

```
cd build
cd pack
```

A new package will be created in `artifacts\`.

# Publishing to nuget.org
The package version is maintained in `build\version.txt`. Make sure to increase that (and commit) before publishing a new version upstream. Also keep that version in sync with the VS package version in `src\Starcounter.VS.VSIX\source.extension.vsixmanifest`. The version is on the `PackageManifest\Metadata\Identity` element.

```
cd build
cd pack_and_push
```

You will need to make sure the Starcounter API key with proper access rights is available through `%StarcounterNuGetKeyFull%`, or pushing will fail.

# Publishing on Visual Studio marketplace
1. Go to https://marketplace.visualstudio.com/items?itemName=Starcounter.StarcounterforVisualStudio
2. Choose `Edit extension`
3. Use `Upload | Change` to upload a new version.

# Resources
* Home on [Visual Studio marketplace](https://marketplace.visualstudio.com/items?itemName=Starcounter.StarcounterforVisualStudio).
* Home for package on [nuget.org](https://www.nuget.org/packages/Starcounter.VisualStudio/).
* [Version compatibility](https://github.com/Starcounter/Starcounter.VisualStudio/wiki/Version-compatibility)
