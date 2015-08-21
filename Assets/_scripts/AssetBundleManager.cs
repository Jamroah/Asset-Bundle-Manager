using UnityEngine;
using System.Collections;
using System.IO;

public class AssetBundleManager : MonoBehaviour
{
    public static string Output;
    private string path;

    IEnumerator Start()
    {
        Debug.Log(Output);

        if (string.IsNullOrEmpty(Output))
            yield break;

        yield return null;
    }

    public static string LocalAssetDirectory()
    {
        return Directory.GetParent(Application.dataPath).FullName + @"\Asset Bundles";
    }
}
