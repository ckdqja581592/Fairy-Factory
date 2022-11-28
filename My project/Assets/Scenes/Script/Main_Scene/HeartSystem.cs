using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] Hearts;
    public int life = 3;
    private bool dead;
    void start()
    {
        //life = hearts.Length;
        //life = 3;
    }

    void Update()
    {
        
    }

    public void Damage()
    {
        life -= 1;
        if (life < 3)
        {
            life = 2;
            Destroy(GameObject.FindWithTag("HP1"));
            Debug.Log("2남음");
        }
        else if (life < 2)
        {
            life = 1;
            Destroy(GameObject.FindWithTag("HP2"));
            Debug.Log("피 1남음");
        }
        else if (life <1)
        {
            life = 0;
            Destroy(GameObject.FindWithTag("HP3"));
            Debug.Log("피 0남음");
        }
    }
}
