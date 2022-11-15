using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthGauge5 : MonoBehaviour
{
    Image healthBar5;
    float maxHealth = 10f;
    public static float health5;
    void Start()
    {
        healthBar5 = GetComponent<Image>();
        health5 = 0;
    }

    void Update()
    {
        healthBar5.fillAmount = health5 / maxHealth;
        if (health5 < 0)
        {
            health5 = 0;
        }
        else if (health5 > 10)
        {
            health5 = 0;
        }
    }
}
