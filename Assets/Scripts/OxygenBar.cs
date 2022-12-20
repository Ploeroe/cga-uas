using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenBar : MonoBehaviour
{
    private Slider slider;
    public Oxygen oxygen;

    public float FillSpeed = 0.1f;
    private float fillAmount;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    private void Start()
    {
        HandleBar();
    }

    private void Update()
    {
        HandleBar();
    }

    public void HandleBar()
    {
        fillAmount = oxygen.loxy / 100f;
        slider.value = fillAmount;
    }
}
