using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Movimiento : MonoBehaviour
{
    public int speed;
    public int rotation1;
    private bool ab = true;
    private Rigidbody2D _rigidbody;

 

    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.AddForce(new Vector2(20f,30f));
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        _rigidbody.velocity = new Vector2(0, 0);
        _rigidbody.AddForce(Vector2.up * 100);
        ab = false;


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Finish") )
        {
            
            Destroy(gameObject,0.1f);
        }

       
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        ab = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ab)
        {
            rebota();
            
        }
        
        
        
    }

    void rebota()
    {
        
        if (transform.position.x >= 8.36f)
        {
            _rigidbody.AddForce(Vector2.left * speed *2 );
            if (_rigidbody.velocity.x < -5)
            {
                _rigidbody.velocity = new Vector2(-5, _rigidbody.velocity.y);
            }
            
        }
        else if (transform.position.x <= -8.36f)
        {   
           
            _rigidbody.AddForce(Vector2.right* speed*2);
            
            if (_rigidbody.velocity.x > 5)
            {
                _rigidbody.velocity = new Vector2(5,  _rigidbody.velocity.y);
            }
        }

        if (transform.position.y >= -0.49)
        {
            
            _rigidbody.AddForce(Vector2.down* speed);
            if (_rigidbody.velocity.y < -5)
            {
                _rigidbody.velocity = new Vector2( _rigidbody.velocity.x, -5);
            }
        }
        else if (transform.position.y <= -4.47)
        {
            
            _rigidbody.AddForce(Vector2.up * speed);
            if (_rigidbody.velocity.y >= 5)
            {
                _rigidbody.velocity = new Vector2( _rigidbody.velocity.x, 5);
            }
        }
    }
}
