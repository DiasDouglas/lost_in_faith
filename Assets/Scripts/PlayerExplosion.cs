using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExplosion : MonoBehaviour
{
    public AudioSource explosao;

    void OnTriggerEnter(Collider other)
    {
        StartExplosion();
    }

    void StartExplosion()
    {
        explosao.enabled = true;
        if (!(explosao.isPlaying))
        {
            explosao.Play();
        }
    }

}
