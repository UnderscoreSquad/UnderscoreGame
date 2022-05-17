using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFade : MonoBehaviour
{
    public GameObject exitScreen;

    private Animator screenAnimator;

    void Start()
    {
        screenAnimator = GetComponent<Animator>();
    }

    public void QuitGame()
    {
        exitScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (exitScreen.activeSelf)
        {
            screenAnimator.SetTrigger("Quit");
        }
    }

    public void OriginalQuitGame()
    {
        Application.Quit();
    }
}
