using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweetFunction : MonoBehaviour
{
    int tweetScore = 0;
    void Start()
    {

    }

    void Update()
    {

    }

    public void Tweet()
    {
        ScoreManager hoge = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        tweetScore = hoge.GameOverScore;
        //本文＋ハッシュタグ＊２ツイート（画像なし）
        naichilab.UnityRoomTweet.Tweet("virusbuster-game", "ゲーム「VirusBuster」でSCORE:" + tweetScore+"を獲得", "unityroom", "unity1week");
        //スコアとゲーム名表示させたいかな？
    }
}
