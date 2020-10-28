using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int max_life = 3;
    public int cur_life = 0;
    Text life;

    // Start is called before the first frame update
    void Start()
    {
        cur_life = max_life;
    }
    public void TakeDamage()
    {
        cur_life -= 1;
        LifeText.lifeCount-=1;
    }

    public void SetLife(){
        life.text = cur_life.ToString();
    }

}
