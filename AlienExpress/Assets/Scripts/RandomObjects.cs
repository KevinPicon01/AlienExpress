using UnityEngine;

public class RandomObjects : MonoBehaviour
{
    public GameObject[] objs = new GameObject[5];

    Random rand;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
        ShuffleObjects(objs);
        
    
        for (int i = 0; i < 3; i++)
        {
            Instantiate(objs[i], new Vector3(i * 1.5f, 0, 0), Quaternion.identity);
        }
        //rand = Random(objs.Length);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gm.SpawnedObject);
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
