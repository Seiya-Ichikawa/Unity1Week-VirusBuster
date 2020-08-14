using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToGame : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void BackGame()
    {
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
        CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
        fadeValue.NoiseX = 1;
    }
}
