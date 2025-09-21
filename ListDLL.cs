using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

public static class ListDlls
{
    [MenuItem("Tools/Diagnostics/List Managed DLLs")]
    public static void ListManagedDlls()
    {
        var asms = AppDomain.CurrentDomain.GetAssemblies();
        var rows = asms
            .Select(a => a.IsDynamic ? null : a.Location)
            .Where(p => !string.IsNullOrEmpty(p))
            .Distinct()
            .OrderBy(p => p)
            .ToList();

        Debug.Log($"Managed DLLs loaded: {rows.Count}");
        foreach (var p in rows) Debug.Log(p);
    }

    [MenuItem("Tools/Diagnostics/List Native Plugins")]
    public static void ListNativePlugins()
    {
        var plugins = PluginImporter.GetAllImporters()
            .Where(pi => Path.GetExtension(pi.assetPath).Equals(".dll", StringComparison.OrdinalIgnoreCase))
            .Select(pi => pi.assetPath)
            .OrderBy(p => p)
            .ToList();

        Debug.Log($"Native plugin files in project: {plugins.Count}");
        foreach (var p in plugins) Debug.Log(p);
    }
}
