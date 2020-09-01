using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class BGMVolumeControl : MonoBehaviour
{
    [SerializeField] private float volumeValue;
    public void BGMVolume()
    {
        //BGM全体のボリュームを変更
        BGMManager.Instance.ChangeBaseVolume(volumeValue);

        //選択時の効果音
        SEManager.Instance.Play(SEPath.SYSTEM22);
    }
}
