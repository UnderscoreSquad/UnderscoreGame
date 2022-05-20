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
    public GameObject loadScreen;
    public GameObject fpsText;
    public GameObject objectText;
    public GameObject heartDisplay;
    public GameObject Player;
    public GameObject Camera;

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
        loadScreen.SetActive(true);
        fpsText.SetActive(false);
        objectText.SetActive(false);
        heartDisplay.transform.localScale = new Vector3(0f, 0f, 1f);
        Player.transform.position = new Vector2(Player.transform.position.x, 91.9f);
        Camera.transform.Translate(0f, -100f, 0f);
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
