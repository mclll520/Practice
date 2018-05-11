using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUGUI_05 : MonoBehaviour {

	void Start () {
        transform.GetComponent<Slider>().onValueChanged.AddListener(OnValueChange);
	}
    public void OnValueChange(float Value) {
        Debug.Log(Value.ToString());
    }
	void Update () {
		
	}
}
