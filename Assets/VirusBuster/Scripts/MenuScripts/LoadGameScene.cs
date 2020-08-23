using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class LoadGameScene : MonoBehaviour
{
    public void ChangeToGameScene()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
        FadeManager.Instance.LoadScene("GameScene", 2.0f);
    }
}
