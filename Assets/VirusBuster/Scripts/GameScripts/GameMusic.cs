using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class GameMusic : MonoBehaviour
{
    void Start()
    {
        BGMManager.Instance.Play(
            audioPath: BGMPath.G,
            volumeRate: 0.3f,
            isLoop: true,
            allowsDuplicate: false
            );
        BGMManager.Instance.FadeIn(1);
    }
}
