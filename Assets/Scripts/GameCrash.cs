using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCrash : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Application.Quit();
    }
}
