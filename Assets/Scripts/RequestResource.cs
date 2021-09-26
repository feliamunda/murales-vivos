using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using JSONObjects;

public class RequestResource : MonoBehaviour
{
    [SerializeField] private int _resourceID;
    private string _urlBase = "http://awesome-walls.feliamunda.com/wp-json/wp/v2/resources/";
    private Resource _resource;
    public Resource Resource { get => _resource; }
    //public string BundleName;

    void OnEnable()
    {
        Debug.Log("Habilitado");
        if (_resourceID > 0)
            StartCoroutine(GetRequest(_urlBase));
    }

    IEnumerator GetRequest(string uri)
    {
        UnityWebRequest request = UnityWebRequest.Get(uri + _resourceID.ToString());
        yield return request.SendWebRequest();
    
        string[] pages = uri.Split('/');
        int page = pages.Length - 1;

        switch (request.result)
        {
            case UnityWebRequest.Result.ConnectionError:
            case UnityWebRequest.Result.DataProcessingError:
                Debug.LogError(pages[page] + ": Error: " + request.error);
                break;
            case UnityWebRequest.Result.ProtocolError:
                Debug.LogError(pages[page] + ": HTTP Error: " + request.error);
                break;
            case UnityWebRequest.Result.Success:
                var json = JSON.Parse(request.downloadHandler.text);
                _resource = new Resource();
                _resource.id = json["id"];
                _resource.name = json["item_name"];
                _resource.asset_name = json["asset_name"];
                StartCoroutine(GetAssetBundle(json["asset_bundle"]["guid"]));
                break;
        }
    }

    IEnumerator GetAssetBundle(string urlAssetBundle)
    {
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(urlAssetBundle);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
        }
        else
        {
            // Get downloaded asset bundle
            _resource.asset_bundle = DownloadHandlerAssetBundle.GetContent(request);
            Debug.Log("Loaded " + _resource.name);
        }        
    }
}
