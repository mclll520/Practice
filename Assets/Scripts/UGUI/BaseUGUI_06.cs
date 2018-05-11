using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUGUI_06 : MonoBehaviour {

	void Start () {
        transform.GetComponent<Scrollbar>().onValueChanged.AddListener(OnChanggeValue);
	}
	
	void Update () {
		
	}

    public void OnChanggeValue(float value) {
        Debug.Log(value.ToString());
    }

}
