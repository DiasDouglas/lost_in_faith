using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetDestroyed : MonoBehaviour
{
    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "StarShip")
        {
            Debug.Log("Collide at Player");

            LifesHandler.Life -= 1;
            LifeText.lifeCount -= 1;

            if (LifesHandler.Life <= 0)
            {
                Invoke("GameOver", 4.0f);

                GameObject exp = Instantiate(explosionPrefab, col.transform.position, col.transform.rotation);

                foreach (Transform child in col.gameObject.transform)
                {
                    Destroy(child.gameObject);
                }

                Destroy(col.gameObject);

            }

            GameObject exp2 = Instantiate(explosionPrefab, gameObject.transform.position, gameObject.transform.rotation);

            foreach (Transform child in gameObject.transform)
            {
                Destroy(child.gameObject);
            }

            Destroy(gameObject);

        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
}
