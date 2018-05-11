using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUGUI_08 : MonoBehaviour {

	void Start () {
        transform.GetComponent<ScrollRect>().onValueChanged.AddListener(OnValueChange);
	}

    private void OnValueChange(Vector2 arg0)
    {
        Debug.Log(arg0.ToString());
    }

    void Update () {
		
	}
}
