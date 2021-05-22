using UnityEngine;
using UnityEditor;

namespace Karting.Scripts.Editor
{
    public class MyEditorScript: MonoBehaviour
    {
        public static void Start()
        {
         
            string[] scenes =
            {
                "Assets/Karting/Scenes/IntroMenu.unity",
                "Assets/Karting/Scenes/LoseScene.unity",
                "Assets/Karting/Scenes/MainScene.unity",
                "Assets/Karting/Scenes/WinScene.unity",
            };
            string locationPathName = @"C:\Users\Anatoly.Cherenkov\Documents\Builds\TolaKart_WebGL";
            BuildPipeline.BuildPlayer(scenes, locationPathName, BuildTarget.WebGL, BuildOptions.None);
        }
    }
}