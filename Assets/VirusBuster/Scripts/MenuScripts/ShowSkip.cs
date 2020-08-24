using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSkip : MonoBehaviour
{
    [SerializeField] GameObject skipButton;

    void Update()
    {
        if (Mathf.Approximately(Time.timeScale, 0f))
        {
            return;
        }

        if (skipButton.activeSelf == true)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            skipButton.SetActive(true);
        }

    }
}
