using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCameraEffect : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
            fadeValue.NoiseX = 1;
        }
    }
}
