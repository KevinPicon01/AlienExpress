using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abd : MonoBehaviour
{
    private BoxCollider2D _box;
    private SpriteRenderer _sprite;
    
    // Start is called before the first frame update
    void Start()
    {
        _box = GetComponent<BoxCollider2D>();
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.enabled = false;
        _box.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _box.enabled = true;
            _sprite.enabled = true;
        }


        if (Input.GetKeyUp(KeyCode.Space))
            {
                _box.enabled = false;
                _sprite.enabled = false;
            }
               


    }
    
}
