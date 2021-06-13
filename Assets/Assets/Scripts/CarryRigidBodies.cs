using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryRigidBodies : MonoBehaviour
{
    public List<Rigidbody2D> rigidBodies = new List<Rigidbody2D>();

    public Vector2 lastPosition;
    Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = transform;
        lastPosition = _transform.position;
    }

    void LateUpdate()
    {
        if (rigidBodies.Count > 0)
        {
            for (int i = 0; i < rigidBodies.Count; i++)
            {
                Rigidbody2D rb = rigidBodies[i];

                Vector2 velocity = ((Vector2)_transform.position-lastPosition);
                rb.transform.Translate(velocity, _transform);
            }
        }
        lastPosition = _transform.position;
    }


    private void OnCollisionEnter2D(Collision2D c)
    {
        Rigidbody2D rb = c.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Add(rb);
        }
                
    }

    private void OnCollisionExit2D(Collision2D c)
    {
        Rigidbody2D rb = c.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Remove(rb);
        }



    }

    void Add(Rigidbody2D rb)
    {
        if (!rigidBodies.Contains(rb))
            rigidBodies.Add(rb);
    }
    void Remove(Rigidbody2D rb)
    {
        if (rigidBodies.Contains(rb))
            rigidBodies.Remove(rb);
    }
}




