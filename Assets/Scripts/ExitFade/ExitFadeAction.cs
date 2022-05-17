using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFadeAction : MonoBehaviour
{
    public GameObject quitFade;

    void Start()
    {
        quitFade.SetActive(true);
    }

    void Update()
    {
        if (quitFade.activeSelf)
        {
            Application.Quit();
        }
    }
}