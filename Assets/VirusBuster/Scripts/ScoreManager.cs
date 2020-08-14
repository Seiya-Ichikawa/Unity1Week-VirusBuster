using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int gameOverScore = 0;
    void Start()
    {
        gameOverScore = PlayerPrefs.GetInt("SaveScore");
        Debug.Log("記録されたスコアはこれ" + gameOverScore);
    }

    void Update()
    {

    }

    public int GameOverScore { set; get; }

}
