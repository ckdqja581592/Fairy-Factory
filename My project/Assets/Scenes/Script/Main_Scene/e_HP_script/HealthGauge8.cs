using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge8 : MonoBehaviour
{
    Image healthBar8;
    float maxHealth = 10f;
    public static float health8;
    void Start()
    {
        healthBar8 = GetComponent<Image>();
        health8 = 0;
    }

    void Update()
    {
        healthBar8.fillAmount = health8 / maxHealth;
        if (health8 < 0)
        {
            health8 = 0;
        }
        else if (health8 == 9)
        {
            health8 = 0;
            Score.scoreinAmount +=1;
        }
    }
}
