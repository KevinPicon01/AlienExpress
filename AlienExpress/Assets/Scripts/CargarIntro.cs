using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarIntro : MonoBehaviour
{
    public string nombreScena;    // Start is called before the first frame update
    public void cargarIntro()
    {
        SceneManager.LoadScene(nombreScena);
    }
}
