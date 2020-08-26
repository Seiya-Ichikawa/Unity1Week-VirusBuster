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
        if (hp == 0)//HPが尽きたら消滅とスコア加算
        {
            //コンボ表示
            ComboSystem combo = GameObject.Find("ComboSystem").GetComponent<ComboSystem>();
            combo.IncreaseCombo();
            //SE流し
            SEManager.Instance.Play(
                audioPath: SEPath.RETRO12,
                volumeRate: 0.1f
                );
            //Scoreコンポーネントを取得してポイントを追加
            //FindObjectOfType<Score>().AddPoint(point); 
            Score score = GameObject.Find("Score").GetComponent<Score>();
            score.AddPoint(point);
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        SEManager.Instance.Play(SEPath.CLICK);
        hp -= 1;
        //Debug.Log("ゲームオブジェクトがクリックされました");
    }
 
}
