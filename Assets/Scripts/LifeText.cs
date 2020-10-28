using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeText : MonoBehaviour
{
    public static int lifeCount = 3;
    Text life;

    // Start is called before the first frame update
    void Start()
    {
        life = GetComponent<Text> ();        
    }

    // Update is called once per frame
    void Update()
    {
        life.text = lifeCount.ToString();
    }
}
