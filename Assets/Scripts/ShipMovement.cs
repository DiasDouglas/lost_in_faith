using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if(transform.localPosition.y < 1.75)
            {
                transform.Translate(new Vector3(0, 2f * Time.deltaTime, 0));
            }
        }
        if (Input.GetKey("s"))
        {
            if (transform.localPosition.y > -1.75)
            {
                transform.Translate(new Vector3(0, -2f * Time.deltaTime, 0));
            }
        }
        if (Input.GetKey("a"))
        {
            if (transform.localPosition.x > -3)
            {
                transform.Translate(new Vector3(2f * Time.deltaTime, 0, 0));
            }
        }
        if (Input.GetKey("d"))
        {
            if (transform.localPosition.x < 3)
            {
                transform.Translate(new Vector3(-2f * Time.deltaTime, 0, 0));
            }
        }
    }
}
