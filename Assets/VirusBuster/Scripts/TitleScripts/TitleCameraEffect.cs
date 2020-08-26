using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleCameraEffect : MonoBehaviour
{
    [SerializeField] private CRT crtCamera;

    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            crtCamera.NoiseX = 1;
        }
    }
}
