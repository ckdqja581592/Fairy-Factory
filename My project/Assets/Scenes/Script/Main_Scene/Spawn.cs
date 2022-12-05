using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    GameObject obj1, obj2, obj3;

    int SpawnObj;
    float SpawnTime;
    
    
    public static bool isPause = false;

    void Awake()
    {
        StartCoroutine(CreatepoopRoutine());
        isPause = false;
    }

    void Update()
    {
        //SpawnPlay();
    }

    IEnumerator CreatepoopRoutine(){
        while(true)
        {
            SpawnPlay();
            if(Score.scoreinAmount <= 3){
                SpawnTime = Random.Range(3.0f, 4.0f);
                yield return new WaitForSeconds(SpawnTime);
            }
            if(Score.scoreinAmount > 3 && Score.scoreinAmount < 7){
                SpawnTime = Random.Range(2.5f, 3.5f);
                yield return new WaitForSeconds(SpawnTime);
            }
            if(Score.scoreinAmount >= 7){
                SpawnTime = Random.Range(2.0f, 2.5f);
                yield return new WaitForSeconds(SpawnTime);
            }
        }
    }
    void SpawnPlay()
    {
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
    }
    public void IsPause()
    {
        isPause =!isPause;
        if(isPause)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        Time.fixedDeltaTime = 0.02f* Time.timeScale;
    }
}