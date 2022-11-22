using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyzone1 : MonoBehaviour
{
    [SerializeField]
    GameObject Bobj1, Bobj2, Bobj3, Box1;

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
        bool Keydown = Input.GetKeyDown(KeyCode.Q);
        if (Keydown){
            ChangeObj +=1;
            if(ChangeObj == 1)
            {
                if (Box1 != null)
                {
                    Destroy(GameObject.FindWithTag("Bobj3"));
                }
                Box1 = Bobj1;
                GameObject obj= Instantiate(Box1, transform.position, Quaternion.identity);
                HPbarIndex = 0;

                if(equipHPbar !=null)     {
                    equipHPbar.SetActive(false);}
                equipHPbar = HPbar[HPbarIndex];
                equipHPbar.SetActive(true);
            }
            else if(ChangeObj == 2)
            {
                Destroy(GameObject.FindWithTag("Bobj1"));
                Box1 = Bobj2;
                GameObject obj = Instantiate(Box1, transform.position, Quaternion.identity);
                HPbarIndex = 1;
                if(equipHPbar !=null)     {
                    equipHPbar.SetActive(false);}
                equipHPbar = HPbar[HPbarIndex];
                equipHPbar.SetActive(true);
            }
            else if (ChangeObj == 3)
            {
                Destroy(GameObject.FindWithTag("Bobj2"));
                Box1 = Bobj3;
                GameObject obj = Instantiate(Box1, transform.position, Quaternion.identity);
                ChangeObj = 0;
                HPbarIndex = 2;
                if(equipHPbar !=null)     {
                    equipHPbar.SetActive(false);}
                equipHPbar = HPbar[HPbarIndex];
                equipHPbar.SetActive(true);
            }
        }
    }
}