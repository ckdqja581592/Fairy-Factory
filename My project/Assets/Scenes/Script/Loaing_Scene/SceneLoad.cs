using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class SceneLoad : MonoBehaviour
{
    public Slider progressbar;
    [SerializeField]private TextMeshProUGUI loadText;
    private void Start()
    {
        StartCoroutine(LoadScene());
        loadText = GetComponent<TextMeshProUGUI>();
    }

    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation operation = SceneManager.LoadSceneAsync("MainScene");
        operation.allowSceneActivation = false;

        while(!operation.isDone)
        {
            yield return null;

            if(progressbar.value < 0.99f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 0.99f, Time.deltaTime);
            }else if(progressbar.value >= 0.99f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 1f, Time.deltaTime);
                operation.allowSceneActivation = true;
            }
        }
    }
}