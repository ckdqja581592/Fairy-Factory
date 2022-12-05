using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverSceneControl : MonoBehaviour
{
    Image FullHeart;
    float MaxHeart = 30f;
    void Start()
    {
        FullHeart = GetComponent<Image>();
    }

    void Update()
    {
        FullHeart.fillAmount = Score.scoreinAmount / MaxHeart;        
    }
}
