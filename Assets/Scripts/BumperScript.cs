using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperScript : MonoBehaviour
{

    public float magnitude;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 force = collision.collider.transform.position - transform.position;
        collision.collider.attachedRigidbody.velocity += (force.normalized * magnitude);
    }
}
