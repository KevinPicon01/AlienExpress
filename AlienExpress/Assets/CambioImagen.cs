using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioImagen : MonoBehaviour
{
    
    
    public GameObject scene1;
    public float x = 19.5f;
    public string sceneName;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && x <= 58.5)
        {
            
            scene1.transform.position = new Vector3(x,0f,0f);
            x += 19.5f;
        }
        else if (Input.GetKeyDown(KeyCode.A) && x >= 58.5)
        {
            SceneManager.LoadScene(sceneName: sceneName);
        }
    }
}
