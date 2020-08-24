using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveHideSkipScript : MonoBehaviour
{
    void Update()
    {
        if (gameObject.activeSelf == true)
        {
            HideSkip hideSkip = GameObject.Find("StartButton").GetComponent<HideSkip>();
            hideSkip.GetComponent<HideSkip>().enabled = true;
        }
    }
}
