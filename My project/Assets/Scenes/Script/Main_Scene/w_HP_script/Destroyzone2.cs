using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Destroyzone2 : MonoBehaviour
{
    [SerializeField]
    GameObject Bobj1, Bobj2, Bobj3, Box2;

    public GameObject[] HPbar;
    GameObject equipHPbar;

    int ChangeObj = 0;

    void Start()
    {

    }

    void Update()
    {
        Change();
    }

    void Change()
    {
        int HPbarIndex = -1;
        bool Keydown = Input.GetKeyDown(KeyCode.W);
        if (Keydown)
        {
            ChangeObj += 1;
            if (ChangeObj == 1)
            {
                if (Box2 != null)
                {
                    Destroy(GameObject.FindWithTag("Bobj6"));
                }
                Box2 = Bobj1;
                GameObject obj = Instantiate(Box2, transform.position, Quaternion.identity);
                HPbarIndex = 0;

                if (equipHPbar != null)
                {
                    equipHPbar.SetActive(false);
                }
                equipHPbar = HPbar[HPbarIndex];
                equipHPbar.SetActive(true);
            }
            else if (ChangeObj == 2)
            {
                Destroy(GameObject.FindWithTag("Bobj4"));
                Box2 = Bobj2;
                GameObject obj = Instantiate(Box2, transform.position, Quaternion.identity);
                HPbarIndex = 1;
                if (equipHPbar != null)
                {
                    equipHPbar.SetActive(false);
                }
                equipHPbar = HPbar[HPbarIndex];
                equipHPbar.SetActive(true);
            }
            else if (ChangeObj == 3)
            {
                Destroy(GameObject.FindWithTag("Bobj5"));
                Box2 = Bobj3;
                GameObject obj = Instantiate(Box2, transform.position, Quaternion.identity);
                ChangeObj = 0;
                HPbarIndex = 2;
                if (equipHPbar != null)
                {
                    equipHPbar.SetActive(false);
                }
                equipHPbar = HPbar[HPbarIndex];
                equipHPbar.SetActive(true);
            }
        }
    }
}