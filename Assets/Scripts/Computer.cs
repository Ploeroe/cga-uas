using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Computer : MonoBehaviour
{
    public GameObject panel;
    public GameObject TextPintuUI;
    public Text textValue;
    bool isTrigger = false;
    public Card card;
    public bool isPanelActive = false;

    // Start is called before the first frame update
    void Start()
    {
        TextPintuUI.SetActive(false);
        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            if(card.isCard){
                textValue.text = "Press E to access control panel";
            }else if(!card.isCard){
                textValue.text = "Access denied";
            }else{
                textValue.text = "Access denied";
            }
            TextPintuUI.SetActive(true);
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            TextPintuUI.SetActive(false);
            panel.SetActive(false);
            isTrigger = false;
            isPanelActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && isTrigger){
            if(card.isCard){
                TextPintuUI.SetActive(false);
                panel.SetActive(true);
                isPanelActive = true;
            }
        }
    }
}
