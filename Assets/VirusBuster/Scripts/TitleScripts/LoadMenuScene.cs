using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class LoadMenuScene : MonoBehaviour
{
    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            FadeManager.Instance.LoadScene("MenuScene", 2.0f);
            //全てのSEとBGMをフェードアウト
            BGMManager.Instance.FadeOut(2);
            SEManager.Instance.FadeOut(2);
        }
    }
}
