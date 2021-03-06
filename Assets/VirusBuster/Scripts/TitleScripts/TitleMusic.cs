﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class TitleMusic : MonoBehaviour
{
    void Start()
    {
        BGMManager.Instance.Play(
            audioPath: SEPath.NOISE,
            volumeRate: 0.03f,
            isLoop: true,
            allowsDuplicate: false
            );
    }

    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            BGMManager.Instance.FadeOut(1);
            SEManager.Instance.Play(SEPath.SYSTEM22);
        }
    }
}
