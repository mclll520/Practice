using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public Image Pro;
    public Text texts;
    private AsyncOperation async;
    private int curProgressValue = 0;
    void Start () {
        StartCoroutine(loadScenes());
	}
    IEnumerator loadScenes() {
        async = SceneManager.LoadSceneAsync("UGUI_技能CD");
        async.allowSceneActivation = false;//加载场景 不让跳转
        yield return async;

    }
	void Update () {

        if (async ==null)
        {
            return;
        }

        int progressValue = 0;
        if (async.progress < 0.9f)
        {
            progressValue = (int)async.progress * 100;
        }
        else {
            progressValue = 100;
        }

        if (curProgressValue<progressValue)
        {
            curProgressValue++;
        }
        texts.text = curProgressValue + "%";
        Pro.fillAmount = curProgressValue / 100f;
        if (curProgressValue==100)
        {
            async.allowSceneActivation = true;
        }
	}
}
