using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public GameObject creditsUI;
    public GameObject titleUI;

    public void ToCreditsMenu()
    {
        creditsUI.SetActive(true);
        titleUI.SetActive(false);
    }

    public void ToTitleMenu()
    {
        creditsUI.SetActive(false);
        titleUI.SetActive(true);
    }
}