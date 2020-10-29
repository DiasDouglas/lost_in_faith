using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

  

    void OnTriggerEnter(Collider other) 
    {
        //other.gameObject.GetComponent<PlayerLife>().TakeDamage();
        if (other.gameObject.name == "StarShip")
        {
            Debug.Log("Collide at Player");

            LifesHandler.Life -= 1;
            LifeText.lifeCount -= 1;

            if (LifesHandler.Life == 0)
            {
                foreach (Transform child in other.gameObject.transform)
                {
                    Destroy(child.gameObject);
                }

                Destroy(other.gameObject);
            }

            foreach (Transform child in gameObject.transform)
            {
                Destroy(child.gameObject);
            }

            Destroy(gameObject);

        }
    }
}
