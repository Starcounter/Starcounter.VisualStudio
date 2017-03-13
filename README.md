# Starcounter Visual Studio development assist

A Visual Studio extension that assist in development and debugging of Starcounter applications. Contain project- and item templates and support the extension to be installed and uninstalled using a VSIX package.

# Build
Build `src\Starcounter.VisualStudio.sln`.

# Pack
The package version is maintained in `build\version.txt`.

```
cd build
cd pack
```

A new package will be created in `artifacts\`.

# Pushing to nuget.org
The package version is maintained in `build\version.txt`. Make sure to increase that (and commit) before publishing a new version upstream.

```
cd build
cd pack_and_push
```

You will need to make sure the Starcounter API key with proper access rights is available through `%StarcounterNuGetKeyFull%`, or pushing will fail.

# Install / uninstall locally
After building, go to `bin\[Configuration]\`. Double-click `Starcounter.VS.vsix`.