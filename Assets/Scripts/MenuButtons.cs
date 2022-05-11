using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public GameObject FadeScreenOne;
    public GameObject FadeScreenTwo;
    public GameObject SplashScreen;

    void Start()
    {
        FadeScreenOne.SetActive(true);
        FadeScreenTwo.SetActive(true);
        SplashScreen.SetActive(true);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
