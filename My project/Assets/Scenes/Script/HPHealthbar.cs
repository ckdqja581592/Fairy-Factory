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
    }
}