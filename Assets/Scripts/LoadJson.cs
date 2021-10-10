using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadJson : MonoBehaviour
{
    public TextAsset Json;
    // Start is called before the first frame update
    void Start()
    {
        LoadJsonData();
        StartCoroutine(LoadJsonURL());
    }

    public void LoadJsonData() {

        ListItems itemsList = JsonUtility.FromJson<ListItems>(Json.text);

        for (int i = 0; i < itemsList.Items.Length; i++)
        {
            Debug.Log(itemsList.Items[i].AssetBundleName);
        }
       
       
    }

     IEnumerator LoadJsonURL()
     {
         string url = "https://intrusive-firearm.000webhostapp.com/murales-vivos/Itemsjson";
         WWW www = new WWW(url);
         yield return www;
        if (www.error == null)
        {
            Processjson(www.text);
        }
        else
        {
            Debug.Log("ERROR: " + www.error);
        }

     }

    private void Processjson(string jsonString)
    {
        ListItems itemsList = JsonUtility.FromJson<ListItems>(Json.text);

        for (int i = 0; i < itemsList.Items.Length; i++)
        {
            Debug.Log(itemsList.Items[i].AssetBundleName);
        }

    }
    
}
