using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChapterSelect : MonoBehaviour
{
    public GameObject chapterSelectUI;
    public GameObject levelSelectUI;
    public GameObject titleUI;

    public void ToChapterSelectMenu()
    {
        chapterSelectUI.SetActive(true);
        titleUI.SetActive(false);
    }

    public void ToTitleMenu()
    {
        chapterSelectUI.SetActive(false);
        titleUI.SetActive(true);
    }

    public void PlayChapter1()
    {
        levelSelectUI.SetActive(true);
        chapterSelectUI.SetActive(false);
    }
}
