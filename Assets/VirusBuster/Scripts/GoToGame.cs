using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class GoToGame : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void GoGame()
    {

        SEManager.Instance.Play(SEPath.SYSTEM22);
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
        CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
        fadeValue.NoiseX = 1;
    }

}
