using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadFade : MonoBehaviour
{
    public GameObject reloadScreen;
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

    public void ReloadScene()
    {
        reloadScreen.SetActive(true);
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
        if (reloadScreen.activeSelf)
        {
            screenAnimator.SetTrigger("Reload");
        }
    }

    public void OriginalReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
