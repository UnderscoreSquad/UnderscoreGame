using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectFadeAction : MonoBehaviour
{
    public GameObject select0Fade;

    void Start()
    {
        select0Fade.SetActive(true);
    }

    void Update()
    {
        if (select0Fade.activeSelf)
        {
            SceneManager.LoadScene("2 Level 0");
        }
    }
}