using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour
{
    [SerializeField] private RequestResource _sourceRequest;
    [SerializeField] private GameObject _refPos;
    private GameObject _instance;
    private AppFunctions _gameManager;

    public void Start()
    {
        _gameManager = GameObject.Find("Scripts").GetComponent<AppFunctions>();
    }

    public void ToogleModel(bool turnOn)
    {
        if (_instance != null)
        {
            _instance.SetActive(turnOn);
        }
        else
        {
            if (turnOn)
            {
                InstanciateModel();
                ChangeUIMessage();
            }
        } 
    }
    private void InstanciateModel()
    {
        if (_sourceRequest.Resource != null)
        {
            GameObject item = _sourceRequest.Resource.asset_bundle.LoadAsset(_sourceRequest.Resource.asset_name) as GameObject;
            _instance = Instantiate(item, _refPos.transform);
        }
    }

    private void ChangeUIMessage()
    {
        var message = "¡Desafio! Intenta encontrar la siguiente pista por tu cuenta";
        if (_sourceRequest.Resource?.ui_hint.Length > 0)
        {
            message = _sourceRequest.Resource.ui_hint;
        }
        _gameManager?.ChangeMessage(message);
    }

}
