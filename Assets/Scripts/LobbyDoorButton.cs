using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LobbyDoorButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextPintuUI;
    public Text textValue;
    bool isOpening = false;
    public Animator pintuAnim;
    bool isTrigger = false;
    public PanelPopUp panelPopUp;

    void Start()
    {
        TextPintuUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(panelPopUp.isOpenDoor){
            textValue.text = "Press E to Open or Close The Door";
            if(obj.gameObject.tag.Equals("Player")) {
                TextPintuUI.SetActive(true);
                isTrigger = true;
            }
        }else{
            textValue.text = "Door Is Locked";
            if(obj.gameObject.tag.Equals("Player")) {
                TextPintuUI.SetActive(true);
                isTrigger = true;
            }
        }
    }

    private void OnTriggerExit(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            TextPintuUI.SetActive(false);
            isTrigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(panelPopUp.isOpenDoor){
            if(Input.GetKeyDown("e") && isTrigger){
                if(!isOpening){
                    pintuAnim.SetBool("isOpening", true);
                    isOpening = true;
                }else if(isOpening){
                    pintuAnim.SetBool("isOpening", false);
                    isOpening = false;
                }
            }
        }
    }
}
