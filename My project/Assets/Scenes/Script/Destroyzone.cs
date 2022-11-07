using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyzone : MonoBehaviour
{
    [SerializeField]
    GameObject Bobj1, Bobj2, Bobj3, bobj1, bobj2, bobj3;
    
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
                bobj1 = Instantiate(Bobj1, transform.position, Quaternion.identity);
                bobj1.tag = "Obj1";
                Destroy(bobj2);
                Destroy(bobj3);
            }
            if(ChangeObj == 2)
            {
                bobj2 = Instantiate(Bobj2, transform.position, Quaternion.identity);
                bobj2.tag = "Obj2";
                Destroy(bobj1);
                Destroy(bobj3);
            }
            if(ChangeObj == 3)
            {
                bobj3 = Instantiate(Bobj3, transform.position, Quaternion.identity);
                bobj3.tag = "Obj3";
                Destroy(bobj1);
                Destroy(bobj2);
                ChangeObj = 0;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obj1"){
                Destroy(collision.gameObject);
                Debug.Log("+1");
            }
        else{
            Destroy(collision.gameObject);
                Debug.Log("-1");
        }
    }
}
