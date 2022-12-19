using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HatchButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextPintuUI;
    public Text textValue;
    bool bukaHatch = false;
    public Animator pintuAnim;
    bool isTrigger = false;

    void Start()
    {
        TextPintuUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        textValue.text = "Press E to Open or Close The Hatch";
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
            if(!bukaHatch){
                pintuAnim.SetBool("isOpening", true);
                bukaHatch = true;
            }else if(bukaHatch){
                pintuAnim.SetBool("isOpening", false);
                bukaHatch = false;
            }
        }
    }
}
