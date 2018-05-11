/*              #########                       
              ############                     
              #############                    
             ##  ###########                   
            ###  ###### #####                  
            ### #######   ####                 
           ###  ########## ####                
          ####  ########### ####               
         ####   ###########  #####             
        #####   ### ########   #####           
       #####   ###   ########   ######         
      ######   ###  ###########   ######       
     ######   #### ##############  ######      
    #######  #####################  ######     
    #######  ######################  ######    
   #######  ###### #################  ######   
   #######  ###### ###### #########   ######   
   #######    ##  ######   ######     ######   
   #######        ######    #####     #####    
    ######        #####     #####     ####     
     #####        ####      #####     ###      
      #####       ###        ###      #        
        ###       ###        ###              
         ##       ###        ###               
__________#_______####_______####______________
    身是菩提树，心如明镜台，时时勤拂拭，勿使惹尘埃。
                我们的未来没有BUG              
* ==============================================================================
* Filename: Text0001
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text0001 : MonoBehaviour {
    [Header("视野的距离")]
    public float viewDistance = 500; 
    [Header("视野的范围")]
    public float viewAngle = 10;
    [Header("判断的物体目标")]
    public Transform playerTransform1;
    public Transform playerTransform2;
    public Text text;
    public Camera Camera;
    private Slider slider;
    
    void Start () {
        slider=GameObject.Find("Slider").GetComponent<Slider>();
		slider.onValueChanged.AddListener(OnValueChanged);
        slider.value = Camera.fieldOfView / 179;
		text=GameObject.Find("Text").GetComponent<Text>();
	}

    private void OnValueChanged(float arg0)
    {
        Debug.Log(arg0);
        if (arg0>0.05f&&arg0<0.95f)
        {
            Camera.fieldOfView = arg0 * 179;
        }
       
    }

    void Update () {  
        Vector3 playerDir1 = playerTransform1.position - transform.position;
        float angle = Vector3.Angle(playerDir1, transform.forward);
        if (angle<=viewAngle)
        {
			text.text="动画一   在视野范围内";
        }
        else
        {
			text.text= "动画一   不在视野范围内";
        }

        Vector3 playerDir2 = playerTransform2.position - transform.position;
        float angle2 = Vector3.Angle(playerDir2, transform.forward);
        if (angle2 <= viewAngle)
        {
            text.text = "动画二   在视野范围内";
        }
        else
        {
            text.text = "动画二   不在视野范围内";
        }
    }
}
