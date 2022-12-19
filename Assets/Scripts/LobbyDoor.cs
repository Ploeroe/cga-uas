using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyDoor : MonoBehaviour
{
    public PanelPopUp panelPopUp;
    public Animator pintuAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(panelPopUp.isOpenDoor){
            pintuAnim.SetBool("bukaPanel", true);
        }else{
            pintuAnim.SetBool("bukaPanel", false);
        }
    }
}
