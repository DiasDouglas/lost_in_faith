using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Blink", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
        {
            CancelInvoke();
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }

    void Blink()
    {
        gameObject.GetComponent<Renderer>().enabled = !gameObject.GetComponent<Renderer>().enabled;
    }
}
