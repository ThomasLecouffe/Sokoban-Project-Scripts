﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayValue : MonoBehaviour
{
    public string textValue;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<Text>().text = textValue + gameObject.GetComponent<Slider>().value;
    }
}
