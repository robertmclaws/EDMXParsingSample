#! "netcoreapp3.0"

// RWM: This is required because of a "feature" in ScriptCs that requires CallerFilePath to run from a separate script file.
#load "ScriptHelpers.csx"

// RWM: This reference is relative to the script. If you put it in another folder, make sure to
//      escape the path with as many "..\" as you need to get back to the project root.
#r "bin/Debug/netstandard2.1/EdmxParsingSample.Data.dll"
#r "nuget: EntityFramework, 6.3.0-preview9-19423-04"
#r "netstandard"

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using EdmxParsingSample.Data;

// RWM: If you move your entities to a subfolder, make sure you escape the second parameter of Path.Combine
//      to point to the solution folder.
var edmxFiles = Directory.GetFiles(GetScriptFolder(), "*.edmx");

// RWM: You could have more than one EDMX file in your project, so we'll loop through each one and
//      build your entities for you.
foreach (var edmx in edmxFiles)
{
    var edmxLoader = new EdmxLoader(edmx);
    edmxLoader.Load();
    foreach (var entity in edmxLoader.Entities)
    {
        Console.WriteLine(entity.Name);
    }
}