using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text finalScoreText;
    int gameOverScore = 0;
    void Start()
    {
        gameOverScore = PlayerPrefs.GetInt("SaveScore");
        //Debug.Log("記録されたスコアはこれ" + gameOverScore);//あとでコメントアウト
        finalScoreText.text = "SCORE : " + gameOverScore.ToString();
    }

    void Update()
    {

    }

    public int GameOverScore
    {
        set { gameOverScore = value; }
        get { return gameOverScore; }
    }

}
