using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BaseUGUI_04 : MonoBehaviour {

    public Dropdown dropdown;
	// Use this for initialization
	void Start () {
        Dropdown.OptionData _date1 = new Dropdown.OptionData();
        _date1.text = "选项1";
        Dropdown.OptionData _date2 = new Dropdown.OptionData();
        _date2.text = "选项2";
        Dropdown.OptionData _date3 = new Dropdown.OptionData();
        _date3.text = "选项3";
        Dropdown.OptionData _date4 = new Dropdown.OptionData();
        _date4.text = "选项4";
        Dropdown.OptionData _date5 = new Dropdown.OptionData();
        _date5.text = "选项5";

        dropdown.options.Add(_date1);
        dropdown.options.Add(_date2);
        dropdown.options.Add(_date3);
        dropdown.options.Add(_date4);
        dropdown.options.Add(_date5);

        dropdown.onValueChanged.AddListener(OnSelectIndex);
    }

    public void OnSelectIndex(int indedx) {
        Debug.Log("当前选择的下标="+indedx.ToString()+"  选项名字:"+dropdown.captionText.text);
    }


    void Update () {
		
	}
}
