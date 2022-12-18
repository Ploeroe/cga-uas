using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TextPintuUI;
    public GameObject text;

    void Start()
    {
        text = GameObject.Find("PintuUI");
        text.SetActive(false);
    }

    private void OnCollisionEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) text.SetActive(true);
    }

    private void OnCollisionStay(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) text.SetActive(true);
    }

    private void OnCollisionExit(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
