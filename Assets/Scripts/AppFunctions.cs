using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppFunctions: MonoBehaviour
{ 
    [SerializeField] private GameObject _circuitObject;
    [SerializeField] private GameObject _menuObject;
    [SerializeField] private GameObject _infoObject;
    [SerializeField] private GameObject _finalScreenObject;

    private TextMeshProUGUI _infoText;

    public void Start()
    {
        _infoText = _infoObject.GetComponentInChildren<TextMeshProUGUI>();       
        _infoText.text = "Bienvenid@, tu primera pista es: \n \"en la plaza Parque Patricios se encuentra un miembro de la familia camélidos, se lo vio por ultima vez junto a un hombre con ruana\"";
        _menuObject.SetActive(true);
    }

    public void ChangeMessage(string message)
    {
        _infoObject.SetActive(false);
        _infoText.text = message;
        _infoObject.SetActive(true);
    }

    public void Resume()
    {
        _circuitObject.SetActive(true);
        _menuObject.SetActive(false);
        _infoObject.SetActive(true);
    }

    public void Explore()
    {
        _finalScreenObject.SetActive(false);
        _infoObject.SetActive(true);
        _infoText.text = "Diviertete explorando de nuevo los lugares descubiertos";
    }

    public void Finish()
    {
        StartCoroutine(showFinalScreen(4f));
    }

    public void Quit()
    {
        Application.Quit();
    }

    private IEnumerator showFinalScreen(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        _finalScreenObject.SetActive(true);
        _circuitObject.SetActive(false);
        _infoObject.SetActive(false);
    }
}
