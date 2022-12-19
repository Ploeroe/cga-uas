using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPopUp : MonoBehaviour
{
    public GameObject panel;
    public Computer computer;
    public bool isOpenDoor = false;

    public Light light;

    public void onClose(){
        panel.SetActive(false);
        computer.isPanelActive = false;
    }

    public void openDoor(){
        isOpenDoor = true;
        light.color = new Color(0f, 1f, 0f, 1f);
        panel.SetActive(false);
        computer.isPanelActive = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
