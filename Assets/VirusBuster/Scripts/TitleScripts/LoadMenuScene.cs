using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMenuScene : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FadeManager.Instance.LoadScene("MenuScene", 2.0f);
        }
    }
}
