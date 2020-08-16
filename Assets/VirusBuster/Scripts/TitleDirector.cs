using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class TitleDirector : MonoBehaviour
{
    void Start()
    {
        BGMManager.Instance.Play(
            audioPath: SEPath.NOISE,
            volumeRate: 0.08f,
            isLoop: true,
            allowsDuplicate: false
            );
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BGMManager.Instance.FadeOut(1);
            SEManager.Instance.Play(SEPath.SYSTEM22);
            FadeManager.Instance.LoadScene("MenuScene", 2.0f);
            CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
            fadeValue.NoiseX = 1;
        }
    }
}
