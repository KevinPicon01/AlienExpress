using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public GameObject gameObject;
    public string SceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            SceneManager.LoadScene(sceneName: SceneName);
        }
    }

    private void FixedUpdate()
    {
       
    }
}
