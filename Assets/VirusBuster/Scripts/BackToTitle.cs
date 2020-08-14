using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToTitle : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void BackTitle()
    {
        FadeManager.Instance.LoadScene("TitleScene", 2.0f);
        CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
        fadeValue.NoiseX = 1;
    }
}
