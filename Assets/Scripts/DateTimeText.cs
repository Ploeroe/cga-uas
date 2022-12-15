using UnityEngine;
using UnityEngine.UI;
using System;

public class DateTimeText : MonoBehaviour
{
    public Text dateTimeText;

    void Update()
    {
        dateTimeText.text = DateTime.Now.ToString("dd MMMM yyyy");
    }
}