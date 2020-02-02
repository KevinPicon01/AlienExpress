﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObjects : MonoBehaviour
{
    public RandomObjects rObjs;

    // Start is called before the first frame update

    private void Awake()
    {
        rObjs = GameObject.FindWithTag("GameController").GetComponent<RandomObjects>();
    }


    void Start()
    {
        for (int i = 0; i < 3; i++) 
        {
            if (i <= 0)
                SetRandomObject01();
            else if (i < 2 && i != 0)
                SetRandomObject02();
            else
                SetRandomObject03();
        }
    }

    void SetRandomObject01() 
    {
        var _obj = Random.Range(0, transform.childCount);
        transform.GetChild(_obj).tag = "ObjetoBuscar";
        transform.GetChild(_obj).GetComponent<SpriteRenderer>().color = rObjs.obj01.GetComponent<SpriteRenderer>().color;
    }

    void SetRandomObject02()
    {
        var _obj = Random.Range(0, transform.childCount);
        transform.GetChild(_obj).tag = "ObjetoBuscar";
        transform.GetChild(_obj).GetComponent<SpriteRenderer>().color = rObjs.obj02.GetComponent<SpriteRenderer>().color;
    }

    void SetRandomObject03()
    {
        var _obj = Random.Range(0, transform.childCount);
        transform.GetChild(_obj).tag = "ObjetoBuscar";
        transform.GetChild(_obj).GetComponent<SpriteRenderer>().color = rObjs.obj03.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
