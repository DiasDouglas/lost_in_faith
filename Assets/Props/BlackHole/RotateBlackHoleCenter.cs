﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlackHoleCenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.up, 50f * Time.deltaTime);
    }
}
