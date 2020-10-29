using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public bool changeCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(changeCamera)
        {
            transform.Translate(new Vector3(3f * Time.deltaTime, 0, 3f * Time.deltaTime));
        }
        else 
        {
            transform.Translate(new Vector3(2f * Time.deltaTime, 0, 0));
        }
        
    }
}
