using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class RankingFunction : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    int rankingScore = 0;
  
    public void Ranking()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
        rankingScore = scoreManager.GameOverScore;
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(rankingScore);
    }
}
