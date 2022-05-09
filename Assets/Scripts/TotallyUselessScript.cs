using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotallyUselessScript : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("4"))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.Quit();
        }
    }
}
