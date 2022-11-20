using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI text;
    public static int scoreinAmount;
    
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();        
    }

    void Update()
    {
        text.text = scoreinAmount.ToString();
    }
}