using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public GameObject levelSelectUI;
    public GameObject titleUI;

    public void ToLevelSelectMenu()
    {
        levelSelectUI.SetActive(true);
        titleUI.SetActive(false);
    }

    public void ToTitleMenu()
    {
        levelSelectUI.SetActive(false);
        titleUI.SetActive(true);
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
