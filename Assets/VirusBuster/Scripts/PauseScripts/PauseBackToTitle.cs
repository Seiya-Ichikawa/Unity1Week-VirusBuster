using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class PauseBackToTitle : MonoBehaviour
{
    public void BackToTitle()
    {
        //全てのBGMを再開
        BGMManager.Instance.UnPause();

        SEManager.Instance.Play(SEPath.SYSTEM22);
        FadeManager.Instance.LoadScene("TitleScene", 2.0f);

        //全てのSEとBGMをフェードアウト
        BGMManager.Instance.FadeOut(2);
        SEManager.Instance.FadeOut(2);
        Time.timeScale = 1f;
    }
}
