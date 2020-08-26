using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class GameManager : MonoBehaviour
{
    GameObject[] enemyObjects;
    float timer = 0.0f;
    float interval = 3.5f;  //Checkの呼び出し頻度
    int numberOfEnemy = 0;
    int limitNumber = 70;

    void Start()
    {

    }

    void Update()
    {
        //画面内のEnemyオブジェクト数の取得
        timer += Time.deltaTime;
        if (timer > interval)
        {
            Check("Enemy");
            CheckCameraEffect();
            timer = 0;
        }

        //一定数以上でGameOver
        if (numberOfEnemy > limitNumber)
        {
            Score hoge = GameObject.Find("Score").GetComponent<Score>();
            PlayerPrefs.SetInt("SaveScore", hoge.ScoreProperty);
            PlayerPrefs.Save();
            GameOver();
            numberOfEnemy = 0;//この記述がないと何度もGameOverメソッドが呼ばれる
        }
    }

    public void GameOver()
    {
        EnemyGenerator enemyGenerator = GameObject.Find("EnemyGenerator").GetComponent<EnemyGenerator>();
        enemyGenerator.GetComponent<EnemyGenerator>().enabled = false;//生成停止
        FadeManager.Instance.LoadScene("GameOverScene", 2.0f);
        CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
        fadeValue.NoiseX = 1;
    }

    public void Check(string tagName)
    {
        enemyObjects = GameObject.FindGameObjectsWithTag(tagName);
        //Debug.Log(enemyObjects.Length);//あとでコメントアウト。これで個数取得
        numberOfEnemy = enemyObjects.Length;
    }
    public void CheckCameraEffect()
    {
        if (numberOfEnemy > 50)//画面効果
        {
            //BGMの調節
            BGMManager.Instance.FadeOut(2);
            //ノイズの追加
            BGMManager.Instance.Play(
            audioPath: SEPath.NOISE,
            volumeRate: 0.2f,
            isLoop: true,
            allowsDuplicate: true
            );

            CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
            fadeValue.NoiseX = 0.05f;
        }
        else if (numberOfEnemy > 60)
        {
            //ノイズの拡大
            BGMManager.Instance.Play(
            audioPath: SEPath.NOISE,
            volumeRate: 0.4f,
            isLoop: true,
            allowsDuplicate: false
            );

            CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
            fadeValue.NoiseX = 0.15f;
        }
        else
        {
            CRT fadeValue = GameObject.Find("Main Camera").GetComponent<CRT>();
            fadeValue.NoiseX = 0.008f;
        }
    }
}
