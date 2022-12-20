using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PanelUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextPintuUI;
    public Text textValue;
    bool bukaPanel = false;
    public Animator pintuAnim;
    bool isTrigger = false;
    public PanelPopUp panelPopUp;
    public PanelParts panelparts;
    private string partsCollected;
    private string partsToCollect;

    void Start()
    {
        TextPintuUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(!panelparts.isOpenPanel){
            partsCollected = panelparts.part.ToString();
            partsToCollect = panelparts.partsToOpenPanel.ToString();
            textValue.text = "You need to collect all parts first : " + partsCollected + " / " + partsToCollect;
        }else if(panelPopUp.isOffGenerator){
            textValue.text = "You need to turn on the generator first";
        }else{
            textValue.text = "Press E to access control panel";
        }
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
        if(panelPopUp.isOffGenerator || !panelparts.isOpenPanel){
            pintuAnim.SetBool("bukaPanel", false);
            bukaPanel = false;
            return;
        }
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
