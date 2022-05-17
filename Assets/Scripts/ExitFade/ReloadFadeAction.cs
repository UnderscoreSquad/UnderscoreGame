using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadFadeAction : MonoBehaviour
{
    public GameObject reloadFade;

    void Start()
    {
        reloadFade.SetActive(true);
    }

    void Update()
    {
        if (reloadFade.activeSelf)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}