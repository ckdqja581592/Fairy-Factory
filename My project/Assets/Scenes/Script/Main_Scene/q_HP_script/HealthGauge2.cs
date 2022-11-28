using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge2 : MonoBehaviour
{
    Image healthBar2;
    float maxHealth = 10f;
    public static float health2;
    void Start()
    {
        healthBar2 = GetComponent<Image>();
        health2 = 0;
    }

    void Update()
    {
        healthBar2.fillAmount = health2 / maxHealth;
        if(health2 < 0){
            health2 = 0;
        }
        else if(health2 == 10){
            health2 = 0;
            Score.scoreinAmount +=1;
        }
    }
}