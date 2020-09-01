using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class PauseCall : MonoBehaviour
{
    [SerializeField] private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
                //全てのBGMを一時停止
                BGMManager.Instance.Pause();
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
                //全てのBGMを再開
                BGMManager.Instance.UnPause();
            }
        }
    }

    public GameObject PauseUIInstance
    {
        set { pauseUIInstance = value; }
        get { return pauseUIInstance; }
    }
}
