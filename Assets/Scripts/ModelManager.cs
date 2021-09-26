using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    [SerializeField] private RequestResource _sourceRequest;
    [SerializeField] private GameObject _refPos;
    private GameObject _instance;
   
    public void ToogleModel(bool turnOn)
    {
        if (_instance != null)
        {
            _instance.SetActive(turnOn);
        }
        else
        {
            if (turnOn)
                InstanciateModel();
        } 
    }
    private void InstanciateModel()
    {
        Debug.Log(_sourceRequest.Resource.asset_bundle);
        Debug.Log(_sourceRequest.Resource.asset_name);
        GameObject item = _sourceRequest.Resource.asset_bundle.LoadAsset(_sourceRequest.Resource.asset_name) as GameObject;
        _instance = Instantiate(item, _refPos.transform);
    }

}
