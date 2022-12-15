using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        timeText.text = System.DateTime.Now.ToString("hh:mm:ss tt");
    }
}




