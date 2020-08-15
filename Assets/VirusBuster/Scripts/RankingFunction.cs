using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RankingFunction : MonoBehaviour
{
    int rankingScore = 0;
    void Start()
    {

    }

    void Update()
    {

    }
    public void Ranking()
    {
        ScoreManager hoge = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        rankingScore = hoge.GameOverScore;
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(rankingScore);
    }
}
