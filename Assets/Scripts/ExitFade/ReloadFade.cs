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

    public void ReloadScene()
    {
        reloadScreen.SetActive(true);
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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
