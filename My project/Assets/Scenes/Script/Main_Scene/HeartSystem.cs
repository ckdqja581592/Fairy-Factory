using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class HeartSystem : MonoBehaviour
{
    Image Heart1;
    Image Heart2;
    Image Heart3;
    public static int life;
    public bool isPause = false;

    public GameObject Spawn;

    public CanvasGroup GameoverGroup;
    void start()
    {
        Heart1 = GetComponent<Image>();
        Heart2 = GetComponent<Image>();
        Heart3 = GetComponent<Image>();
        life = 0;
    }

    void Update()
    {
        if(life == 1)
        {
            Destroy(GameObject.FindWithTag("HP3"));
            life = 1;          
        }
        else if(life == 2)
        {
            Destroy(GameObject.FindWithTag("HP2"));
            life = 2;
        }
        else if(life == 3)
        {
            Destroy(GameObject.FindWithTag("HP1"));
            CanvasGroupOn(GameoverGroup);
            
            Spawn.GetComponent<Spawn>().IsPause();
        }
    }

    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
}