using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BtnType : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BTNType currentType;
    public Transform buttonScale;
    Vector3 defaultScale;
    public CanvasGroup mainGroup;
    public CanvasGroup optionGroup;

    public AudioSource msc;

    private void Start()
    {
        defaultScale = buttonScale.localScale;
    }
    
    bool isSound;
    public void OnBtnClick()
    {
        switch(currentType)
        {
            case BTNType.New:
                SceneManager.LoadScene("LoadingScene");
                break;

            case BTNType.ReStart:
                SceneManager.LoadScene("MainScene");
                break;

            case BTNType.How:
                Debug.Log("게임방법");
                break;

            case BTNType.Option:
                CanvasGroupOn(optionGroup);
                CanvasGroupOff(mainGroup);
                break;

            case BTNType.SoundOn:
                    Debug.Log("사운드on");
                break;

            case BTNType.SoundOff:
                    Debug.Log("사운드off");
                break;

            case BTNType.Next:
                SceneManager.LoadScene("GameOverScene");
                break;

            case BTNType.Back:
                CanvasGroupOn(mainGroup);
                CanvasGroupOff(optionGroup);
                break;

            case BTNType.Quit:
                Application.Quit();
                Debug.Log("끝내기");
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
}
