using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[3];
    int[] table = new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 2 };
    int type = 0;
    [SerializeField] float span = 1.0f;
    [SerializeField] float acceleration = 5.0f;//値が小さいほど早くなる
    float delta = 0;//経過時間
    float elapsedTime = 0;//最初からの経過時間
    float stopAcceleration = 0.2f;//この値以上加速の停止

    void Start()
    {

    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            var randomPosition = new Vector3(Random.Range(-6.5f, 6.5f), Random.Range(3.6f, -3.5f), 0);//画面内のランダムな位置をrandomPositionに
            Instantiate(prefabs[table[type]], randomPosition, Quaternion.identity);//Instantiateに引数として渡す
            type++;
            type %= table.Length;
        }
        if (elapsedTime > acceleration)//生成速度の加速
        {
            if (span <= stopAcceleration) return;
            elapsedTime = 0;
            span -= 0.1f;
        }
    }
}
