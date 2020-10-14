using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMenuOptions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ShowMenuItems", 1.0f);
    }

    void ShowMenuItems()
    {
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}
