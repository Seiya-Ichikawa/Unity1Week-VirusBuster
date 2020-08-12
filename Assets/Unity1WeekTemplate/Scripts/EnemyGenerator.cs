using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[3];
    int[] table = new int[] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 2 };
    int type = 0;
    [SerializeField] float span = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            var randomPosition = new Vector3(Random.Range(-6.5f, 6.5f), Random.Range(3.6f, -3.5f), 0);//画面内のランダムな位置をrandomPositionに
            Instantiate(prefabs[table[type]], randomPosition, Quaternion.identity);//Instantiateに引数として渡す
            type++;
            type %= table.Length;
        }
    }
}
