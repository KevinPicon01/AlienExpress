using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ganar : MonoBehaviour
{
    public void Ganador()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ObjetoBuscar");
        if (objs.Length <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
