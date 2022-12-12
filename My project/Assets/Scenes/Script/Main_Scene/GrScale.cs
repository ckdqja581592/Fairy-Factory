using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrScale : MonoBehaviour
{
    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Score.scoreinAmount>=3 && Score.scoreinAmount<5)
        {
            Rb.gravityScale = 0.15f;
        }
        else if(Score.scoreinAmount>=5 && Score.scoreinAmount<8)
        {
            Rb.gravityScale = 0.25f;
        }
        else if(Score.scoreinAmount>=8 && Score.scoreinAmount<11)
        {
            Rb.gravityScale = 0.33f;
        }
        else if(Score.scoreinAmount>=11 && Score.scoreinAmount<14)
        {
            Rb.gravityScale = 0.4f;
        }
        else if(Score.scoreinAmount>=14 && Score.scoreinAmount<17)
        {
            Rb.gravityScale = 0.5f;
        }
        else if(Score.scoreinAmount>=17 && Score.scoreinAmount<20)
        {
            Rb.gravityScale = 0.62f;
        }
        else if(Score.scoreinAmount>=20 && Score.scoreinAmount<25)
        {
            Rb.gravityScale = 0.75f;
        }
        else if(Score.scoreinAmount>=25 && Score.scoreinAmount<30)
        {
            Rb.gravityScale = 0.9f;
        }
        else if(Score.scoreinAmount>=30 && Score.scoreinAmount<40)
        {
            Rb.gravityScale = 0.5f;
        }
        else if(Score.scoreinAmount>=40)
        {
            Rb.gravityScale = 0.7f;
        }
    }
}
