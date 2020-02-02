using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFondo : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y >= 10.71f)
        {
            transform.position = Vector2.zero;
        }
        else
        {
            gameObject.transform.Translate(0.0f, Time.deltaTime * velocidad,  0.0f);
        }
    }
}
