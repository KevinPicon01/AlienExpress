using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class RotarTierra : MonoBehaviour
{
    public float velocidad;
  
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0.0f,0.0f, velocidad * Time.deltaTime));
    }
}
