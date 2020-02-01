using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
            _rigidbody.AddForce(Vector2.right * speed);
        
        if (Input.GetAxis("Horizontal") < 0 )
            _rigidbody.AddForce(Vector2.left * speed);
        
        
        


    }
}
