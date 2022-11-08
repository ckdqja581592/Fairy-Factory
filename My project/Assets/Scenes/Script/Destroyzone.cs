using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyzone : MonoBehaviour
{
    [SerializeField]
    GameObject Bobj1, Bobj2, Bobj3, Box;
    
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
        bool Keydown = Input.GetKeyDown(KeyCode.Q);

        if (Keydown){
            ChangeObj +=1;

            if(ChangeObj == 1)
            {
                if (Box != null)
                {
                    Destroy(GameObject.FindWithTag("Bobj3"));

                  }

                Box = Bobj1;
                GameObject obj= Instantiate(Box, transform.position, Quaternion.identity);

               
            }
            else if(ChangeObj == 2)
            {
                Destroy(GameObject.FindWithTag("Bobj1"));
                Box = Bobj2;
                GameObject obj = Instantiate(Box, transform.position, Quaternion.identity);

            }
            else if (ChangeObj == 3)
            {
                Destroy(GameObject.FindWithTag("Bobj2"));
                Box = Bobj3;
                GameObject obj = Instantiate(Box, transform.position, Quaternion.identity);

                ChangeObj = 0;
            }
        }
    }

    
}