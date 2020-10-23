using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsCollisionAtPlayer : MonoBehaviour
{
    public ParticleSystem part;
    public ParticleCollisionEvent[] collisionEvents;
    public GameObject explosionPrefab;
    public GameObject player;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new ParticleCollisionEvent[60];
    }

    void OnParticleCollision(GameObject other)
    {
        if(other == player)
        {
            Debug.Log("Collide at Player");

            GameObject exp = Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);

            foreach (Transform child in other.transform)
            {
                Destroy(child.gameObject);
            }

            Destroy(other);
        }
    }
}
