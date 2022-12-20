using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Oxygen : MonoBehaviour
{
    static string[] stringsFrom00To100 = {
        "00", "01", "02","03","04","05","06","07","08","09",
        "10", "11", "12","13","14","15","16","17","18","19",
        "20", "21", "22","23","24","25","26","27","28","29",
        "30", "31", "32","33","34","35","36","37","38","39",
        "40", "41", "42","43","44","45","46","47","48","49",
        "50", "51", "52","53","54","55","56","57","58","59",
        "60", "61", "62","63","64","65","66","67","68","69",
        "70", "71", "72","73","74","75","76","77","78","79",
        "80", "81", "82","83","84","85","86","87","88","89",
        "90", "91", "92","93","94","95","96","97","98","99",
        "100",
    };
    public Text textValue;
    public string textElement;
    public int loxy = 100;
    public bool mati = false;
    private float timeElapsed = 0.0f;
    public GameObject gameObjectToDestroy;
    public GameObject panelGameOver;
    public Button restart;
    float pauseTime;


    // Start is called before the first frame update
    void Start()
    {
        // textValue.text = textElement;
        textValue.text = loxy+"%";
        panelGameOver.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {  
        //update text over time
        // StartCoroutine(UpdateText());
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 1.0f)
        {
            UpdateText();
            timeElapsed = 0.0f;
        }
    }

    void UpdateText(){
        textValue.text = loxy+"%";
        loxy--;
        name = "Pake yang ini";
        if(loxy<0){
            loxy=0;
            mati = true;
            panelGameOver.SetActive(true);
            restart.onClick.AddListener(RestartGame);
        }
    }

    public void RestartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // IEnumerator UpdateText()
    // {
    //     for(int i=100; i>=0 ; i--)
    //     {
    //         // Update the text on the canvas
    //         textValue.text = i + "%";

    //         // Wait for one second before updating the text again
    //         yield return new WaitForSeconds(5.0f);
    //     }
    // }

    // void UpdateText()
    // {
    //     for(int i=100; i>=0 ; i--)
    //     {
    //         // Update the text on the canvas
    //         textValue.text = i + "%";
    //     }
    // }
}
