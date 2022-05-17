using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFade : MonoBehaviour
{
    public GameObject menuScreen;
    public GameObject pauseScreen;
    public GameObject deathScreen;
    public GameObject winScreen;
    public GameObject fpsText;
    public GameObject objectText;
    public GameObject heartDisplay;

    private Animator screenAnimator;

    void Start()
    {
        screenAnimator = GetComponent<Animator>();
    }

    public void LoadMenu()
    {
        menuScreen.SetActive(true);
        pauseScreen.SetActive(false);
        deathScreen.SetActive(false);
        winScreen.SetActive(false);
        fpsText.SetActive(true);
        objectText.SetActive(true);
        heartDisplay.SetActive(true);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (menuScreen.activeSelf)
        {
            screenAnimator.SetTrigger("MainMenu");
        }
    }

    public void OriginalLoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1 Title Screen");
    }
}
