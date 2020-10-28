using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsCollisionAtPlayer : MonoBehaviour
{
    public ParticleSystem part;
    public ParticleCollisionEvent[] collisionEventsAtPlayer;
    public GameObject explosionPrefab;
    public GameObject player;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEventsAtPlayer = new ParticleCollisionEvent[60];
    }

    void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.name == "StarShip")
        {
            Debug.Log("Collide at Player");

            LifesHandler.Life -= 1;
            LifeText.lifeCount -= 1;

            if (LifesHandler.Life == 0)
            {
                GameObject exp = Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);

                foreach (Transform child in other.transform)
                {
                    Destroy(child.gameObject);
                }

                Destroy(other);
            }
        }
    }
}
