using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSkip : MonoBehaviour
{
    [SerializeField] GameObject skipButton;
    void Start()
    {
        //ShowSkipのスクリプト停止
        ShowSkip showSkip = GameObject.Find("MenuManager").GetComponent<ShowSkip>();
        showSkip.GetComponent<ShowSkip>().enabled = false;

        if (skipButton.activeSelf == true)
        {
            //ShowSkipの非アクティブ
            skipButton.SetActive(false);
        }
    }
}
