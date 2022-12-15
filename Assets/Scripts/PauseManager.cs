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
    public Text timeText;
    public string textElement;
    public string s;
    float pauseTime;

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
            if (pauseTime == 0)
            {
                pauseTime = Time.time;
                string time = System.DateTime.Now.ToString("hh:mm:ss tt");
                timeText.text = time;
            }
        }
        else
        {
            Time.timeScale = 1;
            textValue.text = "";
            if (pauseTime > 0)
            {
                pauseTime = Time.time - pauseTime;
            }
            timeText.text = System.DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
