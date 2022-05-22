using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject controlsUI;
    public GameObject titlePauseUI;

    public void ToControlsMenu()
    {
        controlsUI.SetActive(true);
        titlePauseUI.SetActive(false);
    }

    public void ToTitleMenu()
    {
        controlsUI.SetActive(false);
        titlePauseUI.SetActive(true);
    }


}