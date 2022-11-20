using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge4 : MonoBehaviour
{
    Image healthBar4;
    float maxHealth = 10f;
    public static float health4;
    void Start()
    {
        healthBar4 = GetComponent<Image>();
        health4 = 0;
    }

    void Update()
    {
        healthBar4.fillAmount = health4 / maxHealth;
        if (health4 < 0)
        {
            health4 = 0;
        }
        else if (health4 == 10)
        {
            health4 = 0;
            Score.scoreinAmount +=1;
        }
    }
}
