using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUGUI_02 : MonoBehaviour {

	void Start () {
        //单独设置字体大小 size标签
        //transform.GetComponent<Text>().text = "姓名" +"<size=50>"+ "王宇晨"+"</size>";

        //单独设置字体的加粗
        //transform.GetComponent<Text>().text = "姓名" + "<b>" + "王宇晨" + "</b>";

        //单独设置字体的倾斜
        //transform.GetComponent<Text>().text = "姓名" + "<i>" + "王宇晨" + "</i>";

        //单独设置字体的颜色
        //transform.GetComponent<Text>().text = "姓名" + "<color=#FF6613FF>" + "王宇晨" + "</color>";

        //字体大小 加粗 倾斜 颜色
        transform.GetComponent<Text>().text = "姓名" + "<color=#FF6613FF>"+ "<size=50>" + "<i>" + "<b>" + "王宇晨"+"</b>" + "</i>" + "</size>" + "</color>";
    }

    void Update () {
		
	}
}
