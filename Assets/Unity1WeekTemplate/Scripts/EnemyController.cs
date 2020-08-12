using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] int hp = 1;//ヒットポイント
    [SerializeField] int point = 100;//撃破時のスコアポイント
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp == 0)//HPが尽きたら消滅とスコア加算・・・どこに？
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        hp -= 1;
        Debug.Log("ゲームオブジェクトがクリックされました");
    }

}
