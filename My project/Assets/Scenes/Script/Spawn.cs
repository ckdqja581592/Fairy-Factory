using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject obj1, obj2, obj3;

    int SpawnObj;
    
    void Start()
    {
    }

    void Update()
    {
        SpawnPlay();
    }
    void SpawnPlay()
    {
        bool Keydown = Input.GetKeyDown(KeyCode.S);

        if(Keydown)
        {
            SpawnObj = Random.Range(1,4);
            /*obj1 = GameObject.FindWithTag("Obj1");
            obj2 = GameObject.FindWithTag("Obj2");
            obj3 = GameObject.FindWithTag("Obj3");*/

            switch (SpawnObj)
            {
                case 1 :
                Instantiate(obj1, transform.position, Quaternion.identity);
                break;
                case 2 :
                Instantiate(obj2, transform.position, Quaternion.identity);
                break;
                case 3 :
                Instantiate(obj3, transform.position, Quaternion.identity);
                break;
            }
        }
    }
}
