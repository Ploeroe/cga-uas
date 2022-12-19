using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PanelPopUp : MonoBehaviour
{
    public GameObject panel;
    public Computer computer;
    public bool isOpenDoor = false;
    public bool isOffGenerator = false;
    public bool flagOpenDoor = false;

    public Light light;

    public void onClose(){
        panel.SetActive(false);
        computer.isPanelActive = false;
    }

    public void openDoor(){
        if(flagOpenDoor){
            isOpenDoor = false;
            light.color = new Color(1f, 0f, 0f, 1f);
        }else{
            isOpenDoor = true;
            light.color = new Color(0f, 1f, 0f, 1f);
        }
        computer.isPanelActive = false;
        flagOpenDoor = !flagOpenDoor;
        // get gameobject with tag "ButtonTextOpenDoor"
        GameObject[] buttonOpenDoor = GameObject.FindGameObjectsWithTag("ButtonTextOpenDoor");
        foreach(GameObject tempButtonOpenDoor in buttonOpenDoor){
            tempButtonOpenDoor.GetComponent<TextMeshProUGUI>().text = flagOpenDoor? "Close Door" : "Open Door";
        }
    }

    public void offGenerator(){
        isOffGenerator = !isOffGenerator;
        // get gameobject with tag "ButtonTextTurnOffGenerator"
        GameObject[] buttonTurnOffGenerator = GameObject.FindGameObjectsWithTag("ButtonTextTurnOffGenerator");
        foreach(GameObject tempButtonTurnOffGenerator in buttonTurnOffGenerator){
            tempButtonTurnOffGenerator.GetComponent<TextMeshProUGUI>().text = isOffGenerator? "Turn On Generator" : "Turn Off Generator";
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(isOffGenerator){
            GameObject[] lights = GameObject.FindGameObjectsWithTag("Lighting");
            GameObject[] lightsIndicator = GameObject.FindGameObjectsWithTag("Lighting Indicator");
            foreach(GameObject tempLights in lights){
                tempLights.GetComponent<Light>().intensity = 0f;
            }
            foreach(GameObject tempLightsIndicator in lightsIndicator){
                tempLightsIndicator.GetComponent<Light>().intensity = 0f;
            }
        }else{
            GameObject[] lights = GameObject.FindGameObjectsWithTag("Lighting");
            GameObject[] lightsIndicator = GameObject.FindGameObjectsWithTag("Lighting Indicator");
            foreach(GameObject tempLights in lights){
                tempLights.GetComponent<Light>().intensity = 0.6f;
            }
            foreach(GameObject tempLightsIndicator in lightsIndicator){
                tempLightsIndicator.GetComponent<Light>().intensity = 0.6f;
            }
        }
    }
}
