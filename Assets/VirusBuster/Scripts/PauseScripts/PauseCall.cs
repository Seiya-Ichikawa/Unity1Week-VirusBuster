using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class PauseCall : MonoBehaviour
{
    [SerializeField] private GameObject pauseUIPrefab;
    //private GameObject pauseUIInstance;//これをpublicでstaticに
    public static GameObject pauseUIInstance;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseUIInstance == null)                    //もしインスタンス生成されてなかったら生成
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
                //全てのBGMを一時停止
                BGMManager.Instance.Pause();
            }
            else if (pauseUIInstance.activeSelf == true)    //もしアクティブなら非アクティブに
            {
                //Destroy(pauseUIInstance);//破棄から非アクティブに変更
                pauseUIInstance.SetActive(false);
                Time.timeScale = 1f;
                //全てのBGMを再開
                BGMManager.Instance.UnPause();
            }
            else if (pauseUIInstance.activeSelf == false)   //もし非アクティブなら、アクティブに
            {
                pauseUIInstance.SetActive(true);
                Time.timeScale = 0f;
                //全てのBGMを一時停止
                BGMManager.Instance.Pause();
            }

        }
    }

    public GameObject PauseUIInstance
    {
        set { pauseUIInstance = value; }
        get { return pauseUIInstance; }
    }
}
