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
    public float tiempo_start;
    public float tiempo_end;
    public string sceneName;

    public float ubicacionFinal;

    
    // Update is called once per frame
    void Update()
    {
        tiempo_start += Time.deltaTime;


        if (tiempo_start>=tiempo_end && x <= ubicacionFinal)
        {
            LeanTween.moveX(scene1, x, 1f);

            x += 19.5f;
            tiempo_end += 5f;
        }else if (tiempo_start>=tiempo_end && x >= 58.5)
        {
            if (sceneName.Equals("Win"))
            {
                Application.Quit();
            }
            SceneManager.LoadScene(sceneName: sceneName);
        }

        
    }

    

}
