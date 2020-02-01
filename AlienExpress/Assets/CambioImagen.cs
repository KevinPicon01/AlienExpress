using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioImagen : MonoBehaviour
{
    
    
    public GameObject scene1;
    public float x = 19.5f;
    public float tiempo_start = 0.0f;
    public float tiempo_end = 0.0f;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;


        if (tiempo_start>=tiempo_end && x <= 58.5)
        {
            LeanTween.moveX(scene1, x, 1f);

            x += 19.5f;
            tiempo_end += 5f;
        }else if (x >= 58.5)
        {
            SceneManager.LoadScene(sceneName: sceneName);
        }

        // 
        
    }

    

}
