using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBackgroundColor : MonoBehaviour
{
    Camera cam;

    void ChangeColor()
    {
        cam = Camera.main;
        cam.backgroundColor = Color.red;
    }
}
