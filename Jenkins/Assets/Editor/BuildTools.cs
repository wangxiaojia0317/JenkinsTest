using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class BuildTools
{
    public static string BuildPath = @"C:\Users\AC_…Ó¿∂\Desktop\build.exe";
    [MenuItem("Tools/Build")]
    public static void PerformBuild()
    {
        
        BuildPlayerOptions options = new BuildPlayerOptions();
        string[] scenePaths = new string[EditorBuildSettings.scenes.Length];
        for (int i = 0; i < scenePaths.Length; i++)
        {
            scenePaths[i] = EditorBuildSettings.scenes[i].path;
        }
        options.scenes = scenePaths;
        options.target = BuildTarget.StandaloneWindows;
        options.options = BuildOptions.None;
        options.locationPathName = BuildPath;
        BuildPipeline.BuildPlayer(options);
    }
}