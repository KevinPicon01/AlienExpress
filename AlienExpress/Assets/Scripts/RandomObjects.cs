﻿using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] objs = new GameObject[5];

    public GameObject obj01;
    public GameObject obj02;
    public GameObject obj03;

    // Start is called before the first frame update
    void Start()
    {
        ShuffleObjects(objs);
        
        for (int i = 0; i < 3; i++)
        {
            if (i <= 0)
                obj01 = objs[i];
            else if (i < 2 && i != 0)
                obj02 = objs[i];
            else
                obj03 = objs[i];


            Instantiate(objs[i], new Vector3(i * 1.5f, 0, 0), Quaternion.identity);
        }
        //rand = Random(objs.Length);
    }

    void ShuffleObjects(GameObject[] ob)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < ob.Length; t++)
        {
            GameObject tmp = ob[t];
            int r = Random.Range(t, ob.Length);
            ob[t] = ob[r];
            ob[r] = tmp;
            print(ob[t]);
        }
    }
    
}
