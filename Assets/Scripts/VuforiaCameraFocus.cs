using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaCameraFocus : MonoBehaviour
{
    /*private bool statusTracking = true;
    // Start is called before the first frame update
    void Start()
    {
        bool focusModeSet = CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!focusModeSet)
        {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_INFINITY);
            Debug.Log("No es soportado.");
        }

        else {
            Debug.Log("Si es soportado.");
        }



    }

    // Update is called once per frame
    void Update()
    {
        //al tocar activa el focus infinity
        if (Input.touchCount > 0) {
            CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
        }
    }


    public void SetCameraTraking() {
        if (statusTracking)
        {
            statusTracking = false;
            TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
        }
        else {
            statusTracking = true;
            TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
        }
    }*/
}
