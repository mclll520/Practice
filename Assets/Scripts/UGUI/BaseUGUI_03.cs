using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUGUI_03 : MonoBehaviour {

	void Start () {
        transform.GetComponent<Toggle>().onValueChanged.AddListener(OnToggle);
	}

    private void OnToggle(bool arg0)
    {
        if (arg0)
        {
            Debug.Log("显示");
        }
        else {
            Debug.Log("不显示");
        }
    }

    void Update () {
		
	}
}
