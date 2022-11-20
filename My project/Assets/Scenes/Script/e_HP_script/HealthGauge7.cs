using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge7 : MonoBehaviour
{
    Image healthBar7;
    float maxHealth = 10f;
    public static float health7;
    void Start()
    {
        healthBar7 = GetComponent<Image>();
        health7 = 0;
    }

    void Update()
    {
        healthBar7.fillAmount = health7 / maxHealth;
        if (health7 < 0)
        {
            health7 = 0;
        }
        else if (health7 == 10)
        {
            health7 = 0;
            Score.scoreinAmount +=1;
        }
    }
}
