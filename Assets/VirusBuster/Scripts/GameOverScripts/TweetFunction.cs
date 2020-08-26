using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class TweetFunction : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    int tweetScore = 0;

    public void Tweet()
    {
        SEManager.Instance.Play(SEPath.SYSTEM22);
        tweetScore = scoreManager.GameOverScore;
        //本文＋ハッシュタグ＊２ツイート（画像なし）
        naichilab.UnityRoomTweet.Tweet("virusbuster-game", "ゲーム「VirusBuster」でSCORE:" + tweetScore + "を獲得", "unityroom", "unity1week");
    }
}
