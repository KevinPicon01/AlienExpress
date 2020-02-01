using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;


    
    // 0 Antes 1 Durante 2 Despues
    private int jugando = 0;
    public int Jugando
    {
        get
        {
            return jugando;
        }
        set
        {
            jugando = value;
        }
    }

    private GameObject[] spawnedObject = new GameObject[3];
    public GameObject[] SpawnedObject
    {
        get
        {
            return spawnedObject;
        }
        set
        {
            spawnedObject = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.GetString("potato").ToString().Length == 0)
        {
            PlayerPrefs.SetString("potato", "Pamery's God");
        }
    }

}
