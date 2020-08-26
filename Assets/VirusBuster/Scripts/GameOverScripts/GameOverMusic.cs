using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class GameOverMusic : MonoBehaviour
{
    void Start()
    {
        BGMManager.Instance.Play(
           audioPath: BGMPath.MORSE,
           volumeRate: 0.17f,
           isLoop: true,
           allowsDuplicate: false
           );
        BGMManager.Instance.FadeIn(0.5f);

    }
}
