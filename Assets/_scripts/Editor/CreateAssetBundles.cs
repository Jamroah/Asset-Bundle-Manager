using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class CreateAssetBundles
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        string path = AssetBundleManager.LocalAssetDirectory();

        if (!Directory.Exists(path))
        {
            Debug.Log("Directory not found. Creating directory: " + path);
            Directory.CreateDirectory(path);
        }
        //string path = EditorUtility.OpenFolderPanel("Choose Output Folder", "", "");
        //Debug.Log(path);s

        //if(File.Exists(Application.persistentDataPath + @""))

        //BuildPipeline.BuildAssetBundles(path);
    }
}
