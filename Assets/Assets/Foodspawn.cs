using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foodspawn : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject FoodItem;
    public float spawnInterval = 5f;
    public bool spawnerisActive = true;
    public Collider2D below;
    public bool hasEntered = false;
    //private float nextSpawnTime;

    public void Awake()
    {
       // nextSpawnTime = Time.time + spawnInterval;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnTriggerEnter2D(Collider2D below)
    {
       Debug.Log("Charachter Entered Trigger zone");
        if(hasEntered == false)
        {
            GameObject NewObject = (GameObject)Instantiate(FoodItem, spawnLocation.position, transform.rotation);
            hasEntered = true;
        }
       
    }
    private void OnTriggerExit2D(Collider2D below)
    {
        hasEntered = false;
    }



}
