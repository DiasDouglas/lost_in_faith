using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTopDownMovement : MonoBehaviour
{
    private bool rising = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rising)
        {
            if (gameObject.transform.position.y < 1.7)
            {
                gameObject.transform.position =
                    new Vector3(gameObject.transform.position.x,
                        gameObject.transform.position.y + 1.0f * Time.deltaTime,
                        gameObject.transform.position.z);
            }
            else
            {
                rising = false;
            }
        }
        else
        {
            if (gameObject.transform.position.y > -1.7)
            {
                gameObject.transform.position =
                    new Vector3(gameObject.transform.position.x,
                        gameObject.transform.position.y - 1.0f * Time.deltaTime,
                        gameObject.transform.position.z);
            }
            else
            {
                rising = true;
            }
        }
    }
}
