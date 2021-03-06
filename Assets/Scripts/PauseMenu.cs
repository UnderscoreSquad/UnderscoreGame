using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject controlsUI;
    public GameObject optionsUI;
    public GameObject creditsUI;
    public GameObject secretUI;
    public GameObject deathUI;
    public GameObject winUI;
    public GameObject loadUI;
    public GameObject fpsText;
    public GameObject objectText;
    public GameObject heartDisplay;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (controlsUI.activeSelf)
            {
                return;
            }

            if (optionsUI.activeSelf)
            {
                return;
            }
            if (creditsUI.activeSelf)
            {
                return;
            }
            if (secretUI.activeSelf)
            {
                return;
            }
            if (deathUI.activeSelf)
            {
                return;
            }
            if (winUI.activeSelf)
            {
                return;
            }
            if (loadUI.activeSelf)
            {
                return;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            if (pauseMenuUI.activeSelf)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }

            if (GameIsPaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }   else
            {
                Pause();
            }
        }
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        fpsText.SetActive(true);
        objectText.SetActive(true);
        heartDisplay.transform.localScale = new Vector3(1f, 1f, 1f);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        fpsText.SetActive(false);
        objectText.SetActive(false);
        heartDisplay.transform.localScale = new Vector3(0f, 0f, 1f);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1 Title Screen");
    }

    public void ReloadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
