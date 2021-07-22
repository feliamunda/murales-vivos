using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastAR : MonoBehaviour
{
    //public Text debugText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //corresponde al touch de la pantalla
        if (Input.touchCount > 0) {

             Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

             RaycastHit hit;

              if (Physics.Raycast(raycast, out hit)) {

                if (hit.collider.gameObject.name == "BtnPlay") {

                    GameObject.Find("ImageTargetVIdeoPlayer").gameObject.GetComponent<VideoPlayerController>().StartVideo();
                }

                                    
                     //aparece el nombre de lo que se toca
                     /*debugText.text = hit.collider.gameObject.name;*-
                     
                      //desaparece el cubo cuando se toca
                      /*if (hit.collider.gameObject.activeSelf)
                      {

                          hit.collider.gameObject.SetActive(false);
                      }

                      else
                      {
                          hit.collider.gameObject.SetActive(true);
                      }*/

              }

         }

        //esto corresponde a las coordenadas del mouse

        /*float xMousedirection = Input.GetAxis("Mouse X");
        float yMousedirection = Input.GetAxis("Mouse Y");

        Debug.Log("xMousedirection: " + xMousedirection + "yMousedirection" + yMousedirection);

        RaycastHit hit;
        if (Physics.Raycast(new Vector3(xMousedirection, yMousedirection, 0.0f), transform.forward, out hit))
        {
            if (hit.collider.gameObject.activeSelf) {

                hit.collider.gameObject.SetActive(false);
            }
            else 
            {
                hit.collider.gameObject.SetActive(true);
            }
               
        
        
        }*/




    }
}
