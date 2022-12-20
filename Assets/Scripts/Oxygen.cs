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
        if (timeElapsed >= 5.0f)
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
