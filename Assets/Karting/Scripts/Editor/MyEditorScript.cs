using System;
using UnityEngine;
using UnityEditor;

namespace Karting.Scripts.Editor
{
    public class MyEditorScript: MonoBehaviour
    {
        public static void PerformBuild()
        {
            string[] scenes =
            {
                "Assets/Karting/Scenes/IntroMenu.unity",
                "Assets/Karting/Scenes/LoseScene.unity",
                "Assets/Karting/Scenes/MainScene.unity",
                "Assets/Karting/Scenes/WinScene.unity",
            };

            string outputDir = GetArg("-outputDir");
            string defaultOutputDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Builds\TolaKart_WebGL";
            string locationPathName = String.IsNullOrEmpty(outputDir) ? defaultOutputDir : outputDir;
            
            BuildPipeline.BuildPlayer(scenes, locationPathName, BuildTarget.WebGL, BuildOptions.None);
        }

        private static string GetArg(string name)
        {
            string[] args = Environment.GetCommandLineArgs();
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == name && args.Length > i + 1)
                {
                    return args[i + 1];
                }
            }
            return null;
        }
    }
}