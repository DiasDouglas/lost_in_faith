using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsCollisionAtMonster : MonoBehaviour
{
    public ParticleSystem part;
    public ParticleCollisionEvent[] collisionEvents;
    public GameObject explosionPrefab;
    Animator m_Animator;
    bool IsGoingToDie = false;

    void Start()
    {
        part = GetComponent<ParticleSystem>();
        collisionEvents = new ParticleCollisionEvent[60];

    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collide");
        GameObject exp = Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);

        m_Animator = other.GetComponentInParent<Animator>();

        m_Animator.SetTrigger("Die");

        //foreach (Transform child in other.transform)
        //{
        //    Destroy(child.gameObject);
        //}

        //Destroy(other);
    }
}
