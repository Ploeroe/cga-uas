using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public GameObject TextPintuUI;
    public GameObject CardObj;
    public Text textValue;
    bool isTrigger = false;
    public bool isCard = false;

    // Start is called before the first frame update
    void Start()
    {
        TextPintuUI.SetActive(false);
        CardObj.SetActive(true);
    }

    private void OnTriggerEnter(Collider obj){
        textValue.text = "Press E to get card";
        if(obj.gameObject.tag.Equals("Player")) {
            TextPintuUI.SetActive(true);
            isTrigger = true;
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
        if(Input.GetKeyDown("e") && isTrigger){
            if(!isCard){
                CardObj.SetActive(false);
                TextPintuUI.SetActive(false);
                isCard = true;
            }
        }
    }
}
