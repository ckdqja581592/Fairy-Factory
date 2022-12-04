using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPHealthbar : MonoBehaviour
{
    public GameObject Box;
    public Animator animator;
    static AudioSource failSource;
    public static AudioClip failclip;
    static AudioSource successSource;
    public static AudioClip successclip;
    static AudioSource pointSource;
    public static AudioClip pointclip;

    void Start()
    {
        animator = GetComponent<Animator>();
        failSource = GetComponent<AudioSource>();
        failclip = Resources.Load<AudioClip>("fail");
        successSource = GetComponent<AudioSource>();
        successclip = Resources.Load<AudioClip>("success");
        pointSource = GetComponent<AudioSource>();
        pointclip = Resources.Load<AudioClip>("point");
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
                HealthGauge1.health1 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge1.health1 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("booming");
                successSource.PlayOneShot(failclip);
                HealthGauge1.health1 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("booming");
                successSource.PlayOneShot(failclip);
                HealthGauge1.health1 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj2")
        {
            if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge2.health2 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge2.health2 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("MBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge2.health2 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("MBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge2.health2 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj3")
        {
            if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge3.health3 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge3.health3 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("SBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge3.health3 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("SBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge3.health3 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj4")
        {
            if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge4.health4 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge4.health4 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("booming");
                successSource.PlayOneShot(failclip);
                HealthGauge4.health4 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("booming");
                successSource.PlayOneShot(failclip);
                HealthGauge4.health4 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj5")
        {
            if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge5.health5 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge5.health5 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("MBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge5.health5 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("MBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge5.health5 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj6")
        {
            if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge6.health6 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge6.health6 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("SBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge6.health6 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("SBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge6.health6 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj7")
        {
            if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                HealthGauge7.health7 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge7.health7 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("booming");
                successSource.PlayOneShot(failclip);
                HealthGauge7.health7 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("booming");
                successSource.PlayOneShot(failclip);
                HealthGauge7.health7 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj8")
        {
            if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                HealthGauge8.health8 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge8.health8 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("MBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge8.health8 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("MBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge8.health8 = 0f;
                HeartSystem.life += 1;
            }
        }
        if (Box.gameObject.tag == "Bobj9")
        {
            if (collision.gameObject.tag == "Obj3")
            {
                Destroy(collision.gameObject);
                HealthGauge9.health9 += 3f;
                successSource.PlayOneShot(successclip);
                if(HealthGauge9.health9 == 9f){
                    pointSource.PlayOneShot(pointclip);
                    animator.SetTrigger("Fairy");
                }
            }
            else if (collision.gameObject.tag == "Obj1")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("SBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge9.health9 = 0f;
                HeartSystem.life += 1;
            }
            else if (collision.gameObject.tag == "Obj2")
            {
                Destroy(collision.gameObject);
                animator.SetTrigger("SBoom");
                successSource.PlayOneShot(failclip);
                HealthGauge9.health9 = 0f;
                HeartSystem.life += 1;
            }
        }
    }
}