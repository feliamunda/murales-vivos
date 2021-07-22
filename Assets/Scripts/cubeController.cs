using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{

    public string[] UserName;
    public int year;
    public GameObject cube;
    private float ejemplo;
    public Vector3 newPosition;


    private void Awake()
    {
        Debug.Log("INICIA AWAKE");
         
    }

    void Start()
    {
        Debug.Log("INICIA START: "+year.ToString());
    }

    void Update()
    {
        //Debug.Log("INICIA UPDATE");
    }

   /* public void SetEnable() {

        if (cube.activeSelf)
        {
            Debug.Log("INICIA ESTA ACTIVADO");
        }
        else {
            cube.SetActive(true);
        }

    }

    public void SetDiseble()
    {
        if (cube.activeSelf)
        {
            cube.SetActive(false);
        }
        else
        {
            Debug.Log("INICIA ESTA DESACTIVADO");
        }
     
    }*/


    public void SetVisibility(bool v) {

        cube.SetActive(v);

    }

    public void ChangePosition() {
        cube.transform.localPosition = newPosition;
            
    }
    
 
}
