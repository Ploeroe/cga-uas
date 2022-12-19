using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallSpawner : MonoBehaviour
{
    public float timeBetweenSpawns;

    public float spawnDistance;

    public Ball[] ballPrefabs;

    float timeSinceLastSpawn;

    public bool isSpawn = false;
    public bool isTrigger = false;

    public Text textValue;
    public GameObject TextPintuUI;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
        isSpawn = false;
        timeBetweenSpawns = 0.5f;
        Ball.SetActive(false);
    }

    private void OnTriggerEnter(Collider obj){
        if(obj.gameObject.tag.Equals("Player")) {
            textValue.text = "Press E to spawn sphere";
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

    void FixedUpdate()
    {
        if(isSpawn){
        timeSinceLastSpawn += Time.deltaTime;

            if (timeSinceLastSpawn >= timeBetweenSpawns)
            {
                timeSinceLastSpawn -= timeBetweenSpawns;
                SpawnBall();
            }
        }
    }

    void SpawnBall()
    {
        Ball prefab = ballPrefabs[Random.Range(0, ballPrefabs.Length)];
        Ball spawn = Instantiate<Ball>(prefab);
        spawn.transform.localPosition = GameObject.Find("SpherePosition").transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") && isTrigger){
            if(!isSpawn){
                Ball.SetActive(true);
                isSpawn = true;
            }else{
                isSpawn = false;
            }
        }
    }
}
