using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
