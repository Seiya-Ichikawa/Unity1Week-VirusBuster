using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPauseCanvas : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
