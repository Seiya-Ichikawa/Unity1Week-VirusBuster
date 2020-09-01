using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class SEVolumeControl : MonoBehaviour
{
    [SerializeField] private float volumeValue;
    public void SEVolume()
    {
        //SE全体のボリュームを変更
        SEManager.Instance.ChangeBaseVolume(volumeValue);

        //選択時の効果音
        SEManager.Instance.Play(SEPath.SYSTEM22);
    }
}
