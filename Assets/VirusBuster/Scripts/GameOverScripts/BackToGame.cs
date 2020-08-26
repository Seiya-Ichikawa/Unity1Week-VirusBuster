using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class BackToGame : MonoBehaviour
{
    [SerializeField] private CRT crtCamera;

    public void BackGame()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
        crtCamera.NoiseX = 1;
    }
}
