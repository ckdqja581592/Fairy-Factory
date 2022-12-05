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
        if(Score.scoreinAmount>=5 && Score.scoreinAmount<8)
        {
            Rb.gravityScale = 0.25f;
        }
        else if(Score.scoreinAmount>=8 && Score.scoreinAmount<11)
        {
            Rb.gravityScale = 0.35f;
        }
        else if(Score.scoreinAmount>=11 && Score.scoreinAmount<14)
        {
            Rb.gravityScale = 0.45f;
        }
        else if(Score.scoreinAmount>=14 && Score.scoreinAmount<17)
        {
            Rb.gravityScale = 0.55f;
        }
        else if(Score.scoreinAmount>=17 && Score.scoreinAmount<20)
        {
            Rb.gravityScale = 0.65f;
        }
        else if(Score.scoreinAmount>=20 && Score.scoreinAmount<23)
        {
            Rb.gravityScale = 0.75f;
        }
        else if(Score.scoreinAmount>=23 && Score.scoreinAmount<30)
        {
            Rb.gravityScale = 0.85f;
        }
        else if(Score.scoreinAmount>=30)
        {
            Rb.gravityScale = 1.0f;
        }
    }
}
