using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public GameObject controlsUI;
    public GameObject titleUI;

    public void ToControlsMenu()
    {
        controlsUI.SetActive(true);
        titleUI.SetActive(false);
    }

    public void ToTitleMenu()
    {
        controlsUI.SetActive(false);
        titleUI.SetActive(true);
    }


}