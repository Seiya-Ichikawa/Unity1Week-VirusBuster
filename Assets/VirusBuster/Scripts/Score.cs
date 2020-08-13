using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score;

    void Start()
    {

    }

    void Update()
    {
        //スコアの表示
        scoreText.text = "Score : " + score.ToString();

    }

    //ポイントの追加
    public void AddPoint(int point)
    {
        score += point;
    }

    //Retry時の初期化
    private void InitializeScore()
    {
        score = 0;
    }
}
