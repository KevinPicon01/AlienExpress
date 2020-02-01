using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public float moveForce;         
    public float maxSpeed;     
 
    private Vector3 v;
         
    void Update () {
        v = new Vector3(Input.GetAxis("Horizontal"), 
            0.0f, 0.0f);
    }
         
    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = Vector3.ClampMagnitude 
            (GetComponent<Rigidbody2D>().velocity, maxSpeed);
        GetComponent<Rigidbody2D>().AddForce(v.normalized * moveForce);    
        GetComponent<Rigidbody2D>().velocity = GetComponent<Rigidbody2D>().velocity * 0.8f;
    }
        
        


    }

