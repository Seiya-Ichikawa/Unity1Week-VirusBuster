using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class AnimationSounds : MonoBehaviour
{
    void VirusSE()
    {
        SEManager.Instance.Play(
            audioPath: SEPath.RETRO12,
            volumeRate: 0.125f,
            isLoop: false
            );
    }

    void AlarmSE()
    {
        SEManager.Instance.Play(
            audioPath: SEPath.ALERM,
            volumeRate: 0.175f,
            isLoop: true
            );
    }

    void KeyboardSE()
    {
        SEManager.Instance.Play(
            audioPath: SEPath.KEYTYPE3,
            volumeRate: 0.5f,
            isLoop: false
            );
    }

    void AlarmSEFadeOut()
    {
        SEManager.Instance.FadeOut(SEPath.ALERM, 1);
    }
}
