using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Movimiento : MonoBehaviour
{
    public int speed;
    public GameObject objeto;
    private Rigidbody2D _rigidbody;

 

    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.AddForce(new Vector2(20f,30f));
    }

    // Update is called once per frame
    void Update()
    {
        if (objeto.transform.position.x >= 8.36f)
        {
            _rigidbody.AddForce(Vector2.left * speed *2 );
            if (_rigidbody.velocity.x < -5)
            {
                _rigidbody.velocity = new Vector2(-5, _rigidbody.velocity.y);
            }
        }
        else if (objeto.transform.position.x <= -8.36f)
        {   
           
            _rigidbody.AddForce(Vector2.right* speed*2);
            
            if (_rigidbody.velocity.x > 5)
            {
                _rigidbody.velocity = new Vector2(5,  _rigidbody.velocity.y);
            }
        }

        if (objeto.transform.position.y >= -0.49)
        {
            
            _rigidbody.AddForce(Vector2.down* speed);
            if (_rigidbody.velocity.y < -5)
            {
                _rigidbody.velocity = new Vector2( _rigidbody.velocity.x, -5);
            }
        }
        else if (objeto.transform.position.y <= -4.47)
        {
           
            _rigidbody.AddForce(Vector2.up * speed);
            if (_rigidbody.velocity.y >= 5)
            {
                _rigidbody.velocity = new Vector2( _rigidbody.velocity.x, 5);
            }
        }
    }
}
