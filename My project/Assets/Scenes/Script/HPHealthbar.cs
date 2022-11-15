using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPHealthbar : MonoBehaviour
{
    public GameObject Box;

    void Start()
    {
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (Box.gameObject.tag == "Bobj1")
        {
            if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge1.health1 += 2f;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge1.health1 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge1.health1 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj2")
        {
            if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge2.health2 += 2f;
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge2.health2 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge2.health2 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj3")
        {
            if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge3.health3 += 2f;
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge3.health3 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge3.health3 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj4")
        {
            if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge4.health4 += 2f;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge4.health4 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge4.health4 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj5")
        {
            if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge5.health5 += 2f;
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge5.health5 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge5.health5 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj6")
        {
            if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge6.health6 += 2f;
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge6.health6 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge6.health6 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj7")
        {
            if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge7.health7 += 2f;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge7.health7 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge7.health7 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj8")
        {
            if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge8.health8 += 2f;
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge8.health8 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge8.health8 -= 2f;
            }
        }
        if (Box.gameObject.tag == "Bobj9")
        {
            if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge9.health9 += 2f;
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge9.health9 -= 2f;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge9.health9 -= 2f;
            }
        }
    }
}