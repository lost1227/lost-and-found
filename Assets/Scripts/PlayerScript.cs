using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D body;
    public Transform mouse;
    public float scale;
    public float clampMin;
    public float clampMax;
    public float superCharge;

    public float maxVel;

    // Start is called before the first frame update
    void Start()
    {
        body = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 dest = mouse.position;
        Vector3 loc = transform.position;

        Vector2 delta = new Vector2(dest.x - loc.x, dest.y - loc.y);

        // Vector2 afterDest = ((Vector2)dest) + delta.normalized;

        // Vector2 afterDelta = new Vector2(afterDest.x - loc.x, afterDest.y - loc.y);

        Vector2 force = delta.normalized * Mathf.Clamp(delta.sqrMagnitude * scale, clampMin, clampMax);

        if(Input.GetMouseButton(0))
        {
            force *= superCharge;
        }

        // Debug.Log(dest);

        body.AddForce(force.normalized * force.sqrMagnitude);
        //transform.position = new Vector3(dest.x, dest.y, transform.position.z);

        body.velocity = body.velocity.normalized * Mathf.Min(body.velocity.magnitude, maxVel);

        dest.z = transform.position.z;
        Vector3 delta3 = dest - transform.position;
        Vector3 rotatedDelta = Quaternion.Euler(0, 0, 90) * delta3;
        Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedDelta);

        transform.rotation = targetRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
