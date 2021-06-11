using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    
    public float speed = 5;
    private Rigidbody2D rb;
    private Vector2 CounterPosition = new Vector2(5, -3);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position > CounterPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, CounterPosition, speed * Time.deltaTime); 
        }
    }


}
