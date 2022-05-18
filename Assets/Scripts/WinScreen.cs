using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject WinnerMenu;
    public GameObject fpsText;
    public GameObject objectText;
    public GameObject heartDisplay;
    public GameObject mainMusic;
    public GameObject winMusic;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        WinnerMenu.SetActive(true);
        fpsText.SetActive(false);
        objectText.SetActive(false);
        heartDisplay.transform.position = new Vector2(1000f, 1000f);
        mainMusic.SetActive(false);
        winMusic.SetActive(true);
    }

    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BeatGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Win");
    }
}
