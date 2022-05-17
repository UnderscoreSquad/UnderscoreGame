using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectFade : MonoBehaviour
{
    public GameObject select0Screen;

    private Animator screenAnimator;

    void Start()
    {
        screenAnimator = GetComponent<Animator>();
    }

    public void PlayLevel0()
    {
        select0Screen.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (select0Screen.activeSelf)
        {
            screenAnimator.SetTrigger("Select0");
        }
    }

    public void OriginalPlayLevel0()
    {
        SceneManager.LoadScene("2 Level 0");
    }
}
