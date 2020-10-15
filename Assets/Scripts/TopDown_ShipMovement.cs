using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown_ShipMovement : MonoBehaviour
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
            if(transform.localPosition.y < 2)
            {
                transform.Translate(new Vector3(-2f * Time.deltaTime, 0, 0));
            }
        }
        if (Input.GetKey("s"))
        {
            if (transform.localPosition.y > -2)
            {
                transform.Translate(new Vector3(2f * Time.deltaTime, 0, 0));
            }
        }
        if (Input.GetKey("a"))
        {
            if (transform.localPosition.x > -4)
            {
                transform.Translate(new Vector3(0, 0, -2f * Time.deltaTime));
            }
        }
        if (Input.GetKey("d"))
        {
            if (transform.localPosition.x < 4)
            {
                transform.Translate(new Vector3(0, 0, 2f * Time.deltaTime));
            }
        }
    }
}
