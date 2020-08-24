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
        Destroy(pauseCanvas);
        Time.timeScale = 1f;
    }

    public void CloseButtonSE()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
    }
}
