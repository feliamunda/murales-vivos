using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject _background;
    [SerializeField] private AudioSource _audioSFX;
    private bool isMenuFirstTime = true;
    void OnDisable()
    {
        _background.SetActive(false);
    }

    void OnEnable()
    {
        _background.SetActive(true);
        if (isMenuFirstTime)
        {
            _audioSFX.Play();
        }
        isMenuFirstTime = false;
    }

}
