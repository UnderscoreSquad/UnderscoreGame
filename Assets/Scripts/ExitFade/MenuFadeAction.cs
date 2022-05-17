using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFadeAction : MonoBehaviour
{
    public GameObject menuFade;

    void Start()
    {
        menuFade.SetActive(true);
    }

    void Update()
    {
        if (menuFade.activeSelf)
        {
            SceneManager.LoadScene("1 Title Screen");
        }
    }
}