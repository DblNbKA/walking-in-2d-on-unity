using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 10f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.velocity += Vector2.left * Speed;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            rb.velocity += Vector2.right * Speed;
        }
        if (Input.GetKey(KeyCode.W)) 
        {
            rb.velocity += Vector2.up * Speed;
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            rb.velocity += Vector2.down * Speed;
        }
    }
}
