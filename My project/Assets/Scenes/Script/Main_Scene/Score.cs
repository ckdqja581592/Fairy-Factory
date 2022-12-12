using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI text;
    TextMeshProUGUI hightext;
    public static int scoreinAmount = 0;

    public static int highscore=0;
    public string KeyString = "HighScore";
    
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        hightext = GetComponent<TextMeshProUGUI>();
        highscore = PlayerPrefs.GetInt(KeyString,highscore);
        //hightext.text = "High Score: " + highscore.ToString("0");
        hightext.text = "High Score: " + highscore;
    }

    void Update()
    {
        text.text = scoreinAmount.ToString();
        //highscore = 0;
        if(scoreinAmount > highscore)
        {
            PlayerPrefs.SetInt(KeyString, highscore);
        }
    }
}