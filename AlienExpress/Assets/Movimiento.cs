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

    float xIniForce;
    float yIniForce;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        xIniForce = Random.Range(-2.0f, 2.6f);
        yIniForce = Random.Range(-2.0f, 2.6f);

        _rigidbody.AddForce(new Vector2(xIniForce,yIniForce), ForceMode2D.Impulse);
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

        if (transform.position.y >= 4.50)
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
