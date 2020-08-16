﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class MenuMusic : MonoBehaviour
{
    void Start()
    {
        BGMManager.Instance.Play(
           audioPath: SEPath.NOISE,
           volumeRate: 0.08f,
           isLoop: true,
           allowsDuplicate: false
           );
        BGMManager.Instance.FadeIn(1);
    }

    void Update()
    {
        
    }
}
