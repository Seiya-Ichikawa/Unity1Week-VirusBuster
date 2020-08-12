using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
}
