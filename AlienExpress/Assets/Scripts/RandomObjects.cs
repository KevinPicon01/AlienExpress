using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RandomObjects : MonoBehaviour
{
    public string sceneName;
    private float tiempo_start;
    public float tiempo_end;
    public GameObject[] objs = new GameObject[5];

    // Start is called before the first frame update
    void Start()
    {
        ShuffleObjects(objs);
        
        for (int i = 0; i < 3; i++)
        {
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

    private void FixedUpdate()
    {
        tiempo_start += Time.deltaTime;


        if (tiempo_start >= tiempo_end )
        {
            SceneManager.LoadScene(sceneName: sceneName);
        }
    }
}
