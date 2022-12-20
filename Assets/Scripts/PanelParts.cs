using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PanelParts : MonoBehaviour
{
    public GameObject TextPintuUI;
    // declare int part
    public int part = 0;
    // declare partstoOpen panel
    public int partsToOpenPanel = 4;
    public bool isOpenPanel = false;
    public Text textValue;
    bool isTrigger = false;
    private GameObject Part;

    void Start(){
        TextPintuUI.SetActive(false);
        GameObject[] parts = GameObject.FindGameObjectsWithTag("Part");
        foreach(GameObject tempPart in parts){
            tempPart.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Part")){
            textValue.text = "Press E To Collect Part";
            TextPintuUI.SetActive(true);
            isTrigger = true;
        }
        // put set Part value to the colliding obj
        Part = obj.gameObject;
    }

    private void OnTriggerExit(Collider obj){
        if(obj.gameObject.tag.Equals("Part")) {
            TextPintuUI.SetActive(false);
            isTrigger = false;
        }
        Part = null;
    }

    void Update()
    {
        if(Input.GetKeyDown("e") && isTrigger){
            TextPintuUI.SetActive(false);
            if(part < partsToOpenPanel){
                part++;
                Part.SetActive(false);
                if(part == partsToOpenPanel){
                    isOpenPanel = true;
                }
            }
        }
    }

}
