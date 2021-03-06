﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_Shoot : MonoBehaviour
{
    public ParticleSystem ps;

    // Use this for initialization
    void Start()
    {
        StopShooting();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            StartShooting();
        }
        if (Input.GetKeyUp("space"))
        {
            StopShooting();
        }
    }
    void StartShooting()
    {
        ParticleSystem.EmissionModule em = ps.emission;
        em.enabled = true;
    }
    void StopShooting()
    {
        ParticleSystem.EmissionModule e1 = ps.emission;
        e1.enabled = false;
    }
}
