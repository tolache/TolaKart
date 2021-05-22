using System;
using UnityEngine;
using UnityEditor;

namespace Karting.Scripts.Editor
{
    public class MyEditorScript: MonoBehaviour
    {
        public static void PerformBuild(string outputDir)
        {
            string locationPathName;
            if (String.IsNullOrEmpty(outputDir))
            {
                locationPathName = @"C:\Users\Anatoly.Cherenkov\Documents\Builds\TolaKart_WebGL";
            }
            else
            {
                locationPathName = outputDir;
            }
            
            string[] scenes =
            {
                "Assets/Karting/Scenes/IntroMenu.unity",
                "Assets/Karting/Scenes/LoseScene.unity",
                "Assets/Karting/Scenes/MainScene.unity",
                "Assets/Karting/Scenes/WinScene.unity",
            };
            
            BuildPipeline.BuildPlayer(scenes, locationPathName, BuildTarget.WebGL, BuildOptions.None);
        }
    }
}