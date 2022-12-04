using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge6 : MonoBehaviour
{
    Image healthBar6;
    float maxHealth = 10f;
    public static float health6;
    void Start()
    {
        healthBar6 = GetComponent<Image>();
        health6 = 0;
    }

    void Update()
    {
        healthBar6.fillAmount = health6 / maxHealth;
        if (health6 < 0)
        {
            health6 = 0;
        }
        else if (health6 == 9)
        {
            health6 = 0;
            Score.scoreinAmount +=1;
        }
    }
}
