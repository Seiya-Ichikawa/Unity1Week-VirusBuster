using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class BackToTitle : MonoBehaviour
{
    [SerializeField] private CRT crtCamera;

    public void BackTitle()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
        FadeManager.Instance.LoadScene("TitleScene", 2.0f);
        crtCamera.NoiseX = 1;
        //全てのSEとBGMをフェードアウト
        BGMManager.Instance.FadeOut(2);
        SEManager.Instance.FadeOut(2);
    }
}
