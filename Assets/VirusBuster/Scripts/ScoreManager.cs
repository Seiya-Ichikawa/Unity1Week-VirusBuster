using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text finalScoreText;
    private int gameOverScore = 0;
    void Start()
    {
        gameOverScore = PlayerPrefs.GetInt("SaveScore");
        finalScoreText.text = "SCORE : " + gameOverScore.ToString();
    }

    public int GameOverScore
    {
        set { gameOverScore = value; }
        get { return gameOverScore; }
    }

}
