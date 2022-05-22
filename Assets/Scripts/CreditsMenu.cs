using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public GameObject creditsUI;
    public GameObject titlePauseUI;

    public void ToCreditsMenu()
    {
        creditsUI.SetActive(true);
        titlePauseUI.SetActive(false);
    }

    public void ToTitleMenu()
    {
        creditsUI.SetActive(false);
        titlePauseUI.SetActive(true);
    }
}