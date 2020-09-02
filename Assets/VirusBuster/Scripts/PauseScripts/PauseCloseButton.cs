using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class PauseCloseButton : MonoBehaviour
{
    private GameObject pauseCanvas;

    public void ClosePauseButton()
    {
        PauseCall pauseUI = GameObject.Find("PauseController").GetComponent<PauseCall>();
        pauseCanvas = pauseUI.PauseUIInstance;
        //Destroy(pauseCanvas);//破棄から非アクティブに変更
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        //全てのBGMを再開
        BGMManager.Instance.UnPause();
    }

    public void CloseButtonSE()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
    }
}