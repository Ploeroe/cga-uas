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

    void Start()
    {
        text = GameObject.Find("PintuUI");
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            text.SetActive(true);
        }
    }

    private void OnTriggerStay(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            text.SetActive(true);
            if(Input.GetKeyDown("e")){
                if(!bukaPanel){
                    pintuAnim.SetBool("bukaPanel", true);
                    bukaPanel = true;
                }else{
                    pintuAnim.SetBool("bukaPanel", false);
                    bukaPanel = false;
                }
            }
        }
    }

    private void OnTriggerExit(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
