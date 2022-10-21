using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    private AssetBundleCreateRequest bundleRequest;
    private UnityWebRequest request;

    private void Start()
    {
        request = UnityWebRequestAssetBundle.GetAssetBundle("https://drive.google.com/uc?export=download&id=1KDHT2tnOIrht8ucJN0HUnTQP0yaqgt23");
        request.SendWebRequest();
        print("indirildi");
    }

    private void Update()
    {
        if (request.isDone)
        {
            AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
            SceneManager.LoadScene("level1");
        }
    }
}