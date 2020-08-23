using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCall : MonoBehaviour
{
    [SerializeField] private GameObject pauseUIPrefab;
    private GameObject pauseUIInstance;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
            }
        }
    }

    public GameObject PauseUIInstance
    {
        set { pauseUIInstance = value; }
        get { return pauseUIInstance; }
    }
}
