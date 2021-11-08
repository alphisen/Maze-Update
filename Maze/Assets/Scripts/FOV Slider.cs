using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVSlider : MonoBehaviour
{
    public Camera cam;

    void Awake ()
    {
        cam.fieldOfView = 90.0f;
    }


}
