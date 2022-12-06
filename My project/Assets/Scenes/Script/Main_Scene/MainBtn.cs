using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType ctype;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup MSGroup;
    public CanvasGroup MSOptionGroup;
    void Start()
    {
        defaultScale = buttonScale.localScale;
    }

    bool isSound;
    public void OnBtnClick()
    {
        switch(ctype)
        {
            case BTNType.Option:
            CanvasGroupOn(MSOptionGroup);
            CanvasGroupOff(MSGroup);
            break;

            case BTNType.SoundOn:
                    Debug.Log("사운드on");
                break;

                case BTNType.SoundOff:
                    Debug.Log("사운드off");
                break;

                case BTNType.Back:
                CanvasGroupOn(MSGroup);
                CanvasGroupOff(MSOptionGroup);
                break;

                case BTNType.Quit:
                Application.Quit();
                Debug.Log("끝내기");
                break;

            case BTNType.Comeback:
                SceneManager.LoadScene("StartScene");
                break;

        }
    }
    public void CanvasGroupOn(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }
    public void CanvasGroupOff(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void OnPointerEnter(PointerEventData evenData)
    {
        buttonScale.localScale = defaultScale * 1.2f;
    }
    public void OnPointerExit(PointerEventData evenData)
    {
        buttonScale.localScale = defaultScale;
    }

    void Update()
    {
        
    }
}
