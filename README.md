FFailing to compile unsure of codebase. Need to work on at some point.




# Unity-DLL-Locator-C# VRChat world DLL locator or any dll haha
Run:

Tools → Diagnostics → List Managed DLLs

Tools → Diagnostics → List Native Plugins

Manual places to check

Assets/Plugins/**.dll and any subfolders

Packages/* plugin binaries

Library/ScriptAssemblies/*.dll (compiled assemblies; read-only output)

Packages/manifest.json for packages that bring DLLs

If you want the log itself to include managed DLL names, launch the Editor and run the menu action once; the list will appear in Editor.log.



I personally use this to reverse engineer vrchat worlds that are massively outdated and totally not built that way to prevent modification of their world. 
