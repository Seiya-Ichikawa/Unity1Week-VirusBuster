using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int hp = 1;//ヒットポイント
    [SerializeField] int point = 100;//撃破時のスコアポイント
    
    void Start()
    {

    }

    void Update()
    {
        if (hp == 0)//HPが尽きたら消滅とスコア加算
        {
            //Scoreコンポーネントを取得してポイントを追加
            FindObjectOfType<Score>().AddPoint(point);
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        hp -= 1;
        //Debug.Log("ゲームオブジェクトがクリックされました");
    }

}
