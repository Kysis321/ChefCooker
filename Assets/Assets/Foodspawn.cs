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

    private float nextSpawnTime;

    public void Awake()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OntriggerEnter2D(Collider2D below)
    {
        Debug.Log("Charachter Entered Trigger zone");
        GameObject NewObject = (GameObject)Instantiate(FoodItem, spawnLocation.position, transform.rotation);
    }



}
