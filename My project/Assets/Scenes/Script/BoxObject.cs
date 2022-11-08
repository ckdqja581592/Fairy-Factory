using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoxObject : MonoBehaviour
{
    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obj1")
        {
            if (Box.gameObject.tag == "Bobj1")
            {
                Destroy(collision.gameObject);
                Debug.Log("+1");
            }
            else if (Box.gameObject.tag == "Bobj2")
            {
                Destroy(collision.gameObject);
                Debug.Log("-1");
            }
            else if (Box.gameObject.tag == "Bobj3")
            {
                Destroy(collision.gameObject);
                Debug.Log("-1");
            }
        }
        if (collision.gameObject.tag == "Obj2")
        {
            if (Box.gameObject.tag == "Bobj2")
            {
                Destroy(collision.gameObject);
                Debug.Log("+1");
            }
            else if (Box.gameObject.tag == "Bobj1")
            {
                Destroy(collision.gameObject);
                Debug.Log("-1");
            }
            else if (Box.gameObject.tag == "Bobj3")
            {
                Destroy(collision.gameObject);
                Debug.Log("-1");
            }
        }
        if (collision.gameObject.tag == "Obj3")
        {
            if (Box.gameObject.tag == "Bobj3")
            {
                Destroy(collision.gameObject);
                Debug.Log("+1");
            }
            else if (Box.gameObject.tag == "Bobj1")
            {
                Destroy(collision.gameObject);
                Debug.Log("-1");
            }
            else if (Box.gameObject.tag == "Bobj2")
            {
                Destroy(collision.gameObject);
                Debug.Log("-1");
            }
        }

    }
}
