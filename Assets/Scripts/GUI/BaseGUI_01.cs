using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGUI_01 : MonoBehaviour {

	void Start () {
		
	}

    void OnGUI()
    {
        if ((Time.time%2)<1)
        {
            if (GUI.Button(new Rect(10, 10, 120, 100), "按钮"))
            {
                print("按钮点击触发");
            }
        }
      
    }

    void Update () {
		
	}
}
