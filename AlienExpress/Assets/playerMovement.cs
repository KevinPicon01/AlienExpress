using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveForce;         
    public float maxSpeed;
    private Rigidbody2D _rigidbody2D;
    private Vector3 v;
         
    void Update () 
    {
        v = new Vector3(Input.GetAxis("Horizontal"), 
            0.0f, 0.0f);
    }
         
    void FixedUpdate() 
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude 
            (GetComponent<Rigidbody2D>().velocity, maxSpeed);
        GetComponent<Rigidbody2D>().AddForce(v.normalized * moveForce);    
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 0.8f;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Teleport")) 
        {
            if (transform.position.x > 0)
                transform.position = new Vector3(-9.543401f, transform.position.y, 0.0f);
            else
                transform.position = new Vector3(9.544417f, transform.position.y, 0.0f);
        }
    }

}

