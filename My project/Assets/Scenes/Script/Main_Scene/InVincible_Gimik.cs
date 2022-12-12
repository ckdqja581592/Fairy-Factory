using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InVincible_Gimik : MonoBehaviour
{

    bool isInvisible;
    Rigidbody2D rigidbody;
    SpriteRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        isInvisible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Score.scoreinAmount >= 1)
        {
           
            if (isInvisible)
            {
                renderer.color = new Color(0, 0, 0, 0.5f);

            }
           else
            {
                renderer.color = new Color(1, 1, 1, 1);
            }
            
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Score.scoreinAmount >= 1)
        {
            if (collision.gameObject.CompareTag("Gimik"))
            {
                isInvisible = false;

            }
        }
    }

}
