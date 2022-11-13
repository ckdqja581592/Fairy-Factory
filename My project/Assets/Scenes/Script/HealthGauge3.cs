using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge3 : MonoBehaviour
{
    Image healthBar3;
    float maxHealth = 10f;
    public static float health3;
    void Start()
    {
        healthBar3 = GetComponent<Image>();
        health3 = 0;
    }

    void Update()
    {
        healthBar3.fillAmount = health3 / maxHealth;
        if(health3 < 0){
            health3 = 0;
        }
        else if(health3 > 10){
            health3 = 0;
        }
    }
}
