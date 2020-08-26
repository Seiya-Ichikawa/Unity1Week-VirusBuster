using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class LoadGameScene : MonoBehaviour
{
    public void ChangeToGameScene()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        SEManager.Instance.Play(SEPath.SYSTEM22);
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
        //全てのSEとBGMをフェードアウト
        BGMManager.Instance.FadeOut(2);
        SEManager.Instance.FadeOut(2);
    }
}
