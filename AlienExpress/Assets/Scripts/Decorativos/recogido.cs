using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recogido : MonoBehaviour
{
    private Ganar g;

    private void Start()
    {
        g = GameObject.FindWithTag("Player").GetComponent<Ganar>();
    }

    private bool canReduce = true;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.CompareTag("ObjetoBuscar"))
        {
            Escalado();
            g.Ganador();
        }
    }

    void Escalado()
    {
        if (transform.localScale.x <= 0.4f && transform.localScale.y <= 0.4f)
        {
            g.Ganador();
            Destroy(gameObject);
        }
        else if(canReduce)
        {
            var x = transform.localScale.x;
            var y = transform.localScale.y;

            x -= 0.2f;
            y -= 0.2f;
            gameObject.transform.localScale = new Vector3( x, y, 0.0f);
        }
    }
    IEnumerator espere()
    {
        yield return new WaitForSeconds(1.0f);
    }



}
