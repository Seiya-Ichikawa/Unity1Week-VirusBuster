using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSkipTime : MonoBehaviour
{
    float delta = 0;//経過時間
    float span = 3.0f;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            gameObject.SetActive(false);
        }
    }
}
