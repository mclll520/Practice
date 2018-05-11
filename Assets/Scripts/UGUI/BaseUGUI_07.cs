using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUGUI_07 : MonoBehaviour {

    public InputField inputField;
    void Start() {
        inputField.onValueChanged.AddListener(OnValueChange);
        inputField.onEndEdit.AddListener(OnValueEnd);
    }

    public void OnValueChange(string content) {
        Debug.Log("当前内容:" + inputField.text);
    }

    public void OnValueEnd(string content) {
        Debug.Log("最终内容:" + inputField.text);
    }
}
