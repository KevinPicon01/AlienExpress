using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Morir : MonoBehaviour
{
    public float changeTime;
    public string sceneName;
    // Start is called before the first frame update
  
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("ObjetoBuscar") )
        {
            StartCoroutine(nextScene());
        }
    }
    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(changeTime);
        SceneManager.LoadScene(sceneName: sceneName);
    }
   
}
