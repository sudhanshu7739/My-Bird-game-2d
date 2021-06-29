using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour
{
    public GameObject loadingscreen;
    public Slider slidrr;
    public Text text;
    

    public void Loadlevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyn(sceneIndex));
        

    }
    IEnumerator LoadAsyn(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingscreen.gameObject.SetActive(true);
        while (operation.isDone == false)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            text.text = progress * 100 + "%";
            slidrr.value = progress;
            Debug.Log(progress);
            yield return null;
        }

    }
}
