using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int hp = 1;//ヒットポイント
    [SerializeField] int point = 100;//撃破時のスコアポイント

    void Update()
    {
        //HPが尽きたら消滅とスコア加算
        if (hp == 0)
        {
            //コンボ表示
            ComboSystem combo = GameObject.Find("ComboSystem").GetComponent<ComboSystem>();
            combo.IncreaseCombo();
            //SE流し
            SEManager.Instance.Play(
                audioPath: SEPath.RETRO12,
                volumeRate: 0.15f
                );
            //Scoreコンポーネントを取得してポイントを追加
            Score score = GameObject.Find("Score").GetComponent<Score>();
            score.AddPoint(point);
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        SEManager.Instance.Play(
            audioPath: SEPath.CLICK,
            volumeRate: 0.25f
            );
        hp -= 1;
    }

}
