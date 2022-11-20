using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge9 : MonoBehaviour
{
    Image healthBar9;
    float maxHealth = 10f;
    public static float health9;
    void Start()
    {
        healthBar9 = GetComponent<Image>();
        health9 = 0;
    }

    void Update()
    {
        healthBar9.fillAmount = health9 / maxHealth;
        if (health9 < 0)
        {
            health9 = 0;
        }
        else if (health9 == 10)
        {
            health9 = 0;
            Score.scoreinAmount +=1;
        }
    }
}
