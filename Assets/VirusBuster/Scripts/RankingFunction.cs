using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

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
        SEManager.Instance.Play(SEPath.SYSTEM22);
        ScoreManager hoge = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        rankingScore = hoge.GameOverScore;
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(rankingScore);
    }
}
