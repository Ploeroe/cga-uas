using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextPintuUI;
    public GameObject text;
    bool bukaPanel = false;
    public Animator pintuAnim;
    bool isTrigger = false;

    void Start()
    {
        text = GameObject.Find("PintuUI");
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
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
