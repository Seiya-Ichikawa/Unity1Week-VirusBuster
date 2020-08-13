using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleDirector : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeManager.Instance.LoadScene("MenuScene", 2.0f);
            CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
            fadeValue.NoiseX = 1;
        }
    }
}
