using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUnlock : MonoBehaviour
{
    public GameObject Key;
    public GameObject Door;
    public GameObject Trigger;
    public GameObject Warning;

    void Start()
    {
        Warning.SetActive(false);
        Door.SetActive(true);
        Trigger.SetActive(true);
        Key.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (Key.activeSelf)
        {
            Key.SetActive(false);
            Door.SetActive(false);
            Trigger.SetActive(false);
        }

        else if (!Key.activeSelf)
        {
            Warning.SetActive(true);
            return;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Warning.SetActive(false);
        }
    }
}
