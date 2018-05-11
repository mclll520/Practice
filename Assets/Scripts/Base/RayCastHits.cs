using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastHits : MonoBehaviour {

    int target;
	void Start () {
        target = LayerMask.GetMask("cube");
        print(target);
	}

   
    void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray,out hit, 100f,target))
        {
            Debug.DrawLine(ray.origin, hit.point,Color.red);
            GameObject obj = hit.collider.gameObject;
            Debug.Log("名字：" + obj.name);
            if (obj.tag == "pack")
            {
                Debug.Log("拾取");
            }
            else {
                Debug.Log("无法拾取");
            }
        }
	}
}
