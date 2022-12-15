using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PauseManager : MonoBehaviour
{
    bool isPaused = false;
    public Text textValue;
    public string textElement;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0;
            textValue.text = "Paused";
        }
        else
        {
            Time.timeScale = 1;
            textValue.text = "";
        }
    }
}
