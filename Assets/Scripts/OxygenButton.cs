using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OxygenButton : MonoBehaviour
{
    public Oxygen oxygen;
    public GameObject TextPintuUI;
    public Text textValue;
    bool isRefill = false;
    bool isTrigger = false;

    void Start()
    {
        TextPintuUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(!isRefill){
            textValue.text = "Press E to Refill Oxygen";
            if(obj.gameObject.tag.Equals("Player")) {
                TextPintuUI.SetActive(true);
                isTrigger = true;
            }
        }else{
            textValue.text = "You Have Refill Oxygen Once";
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
        if(Input.GetKeyDown("e") && isTrigger){
            if(!isRefill){
                oxygen.loxy = 100;
                isRefill =  true;
            }
        }
    }
}
