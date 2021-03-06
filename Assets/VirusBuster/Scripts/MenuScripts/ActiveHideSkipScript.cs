﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveHideSkipScript : MonoBehaviour
{
    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            //StartButtonが表示されたら、HideSkipスクリプトを有効化
            HideSkip hideSkip = GameObject.Find("StartButton").GetComponent<HideSkip>();
            hideSkip.enabled = true;
        }
    }
}
