using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score;//これをGameOverSceneまで持っていきたい

    void Start()
    {
        InitializeScore();
    }

    void Update()
    {
        //スコアの表示
        scoreText.text = "SCORE : " + score.ToString();

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
    //プロパティ
    public int ScoreProperty
    {
        set { score = value; }
        get { return score; }
    }

}
