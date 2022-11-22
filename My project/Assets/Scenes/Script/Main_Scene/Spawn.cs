using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject obj1, obj2, obj3;

    int SpawnObj;
    float SpawnTime;
    
    void Start()
    {
        StartCoroutine(CreatepoopRoutine());
    }

    void Update()
    {
        //SpawnPlay();
    }

    IEnumerator CreatepoopRoutine(){
        while(true)
        {
            SpawnPlay();
            if(Score.scoreinAmount <= 5){
                SpawnTime = Random.Range(3.0f, 4.0f);
                yield return new WaitForSeconds(SpawnTime);
            }
            if(Score.scoreinAmount > 5 && Score.scoreinAmount < 10){
                SpawnTime = Random.Range(1.0f, 2.0f);
                yield return new WaitForSeconds(SpawnTime);
            }
        }
    }
    void SpawnPlay()
    {
        //bool Keydown = Input.GetKeyDown(KeyCode.S);

        //if(Keydown)
        //{
            //Vector3 pos = new Vector3(0,6,0);
            SpawnObj = Random.Range(1,4);

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
        //}
    }
}