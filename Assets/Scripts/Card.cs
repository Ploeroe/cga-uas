using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public GameObject TextPintuUI;
    public GameObject text;
    bool bukaPanel = false;
    public Animator pintuAnim;
    bool isTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("PintuUI");
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            text.text = "Press E to get card";
            text.SetActive(true);
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            text.SetActive(false);
            isTrigger = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && isTrigger){
            if(!bukaPanel){
                pintuAnim.SetBool("bukaPanel", true);
                bukaPanel = true;
            }else if(bukaPanel){
                pintuAnim.SetBool("bukaPanel", false);
                bukaPanel = false;
            }
        }
    }
}
