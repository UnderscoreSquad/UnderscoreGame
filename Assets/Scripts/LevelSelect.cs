using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject levelSelectUI;
    public GameObject chapterUI;

    public void ToLevelSelectMenu()
    {
        levelSelectUI.SetActive(true);
        chapterUI.SetActive(false);
    }

    public void ToChapterMenu()
    {
        levelSelectUI.SetActive(false);
        chapterUI.SetActive(true);
    }

    public void SplashPlayLevel0()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayLevel0()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
