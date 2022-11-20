using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge1 : MonoBehaviour
{
    Image healthBar1;
    float maxHealth = 10f;
    public static float health1;
    void Start()
    {
        healthBar1 = GetComponent<Image>();
        health1 = 0;
    }

    void Update()
    {
        healthBar1.fillAmount = health1 / maxHealth;
        if(health1 < 0){
            health1 = 0;
        }
        else if(health1 == 10){
            health1 = 0;
            Score.scoreinAmount +=1;
        }
    }
}
