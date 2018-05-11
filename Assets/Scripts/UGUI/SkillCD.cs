using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCD : MonoBehaviour {

    public Button button;
    public Image image;
    public Text text;

    private const float Max_CD = 3;
    private float timer;

	void Start () {
        EndSkill();
        button.onClick.AddListener(OnClckBtu);
	}
    

    private void OnClckBtu()
    {
        StartSkill();
    }

    void Update () {
        if (button.interactable == false)
        {

            if (image.fillAmount<=1f && image.fillAmount >0f)
            {
                timer += Time.deltaTime;
                image.fillAmount = (Max_CD - timer) / Max_CD;
                text.text = Mathf.CeilToInt(Max_CD - timer).ToString();
                if (image.fillAmount == 0)
                {
                    EndSkill();
                }
            }
        }
	}

    void StartSkill() {
        button.interactable = false;
        image.fillAmount = 1f;
        text.text = Max_CD.ToString();
        timer = 0;
    }

    void EndSkill() {
        button.interactable = true;
        image.fillAmount = 0f;
        text.text = string.Empty;
        timer = 0;
    }
}
