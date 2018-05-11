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
* Filename: Soldier
* Created:  $time$
* Author:   WYC
* Purpose:  视觉感知的实现和听觉
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour {
    public float viewDistance = 5; //视野的距离
    public float viewAngle = 120;  //视野的范围

    public Transform playerTransform;

	//void Start () {
 //       playerTransform = GameObject.Find("Player").transform;
	//}
	
	
	void Update () {
        if (Vector3.Distance(playerTransform.position,transform.position) <= viewDistance)
        {
            //得到方位
            Vector3 playerDir = playerTransform.position - transform.position;
            //得到夹角
            float angle = Vector3.Angle(playerDir, transform.forward);
            //判断是否在视野范围内
            if (angle<=viewAngle/2)
            {
                Debug.Log("在视野范围内");
            }

        }
	}
}
