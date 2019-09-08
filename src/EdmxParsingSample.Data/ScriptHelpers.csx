using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

// RWM: These are ScriptCs tricks to get the current script path, but it required being called from another file.
public static string GetScriptPath([CallerFilePath] string path = null) => path;
public static string GetScriptFolder([CallerFilePath] string path = null) => Path.GetDirectoryName(path);


public static void CleanOtherFiles(List<string> filesToKeep)
{
    foreach (var file in Directory.GetFiles(GetScriptFolder(), "*.Generated.cs").Where(c => !filesToKeep.Contains(c)))
    {
        File.Delete(file);
    }
}
