using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleScript : MonoBehaviour
{
    public Rigidbody2D player;
    public LayerMask playerLayerMask;

    public float strength;

    private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = transform.GetComponent<CircleCollider2D>();
    }

    private void FixedUpdate()
    {
        if(Physics2D.OverlapCircle(col.bounds.center, col.bounds.extents.x * 2))
        {
            Vector2 dir = ((Vector2)transform.position) - player.position;
            player.AddForce(dir.normalized * strength);
            Debug.DrawLine(transform.position, player.position);
            Debug.DrawLine(col.bounds.center, col.bounds.center + col.bounds.extents);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
