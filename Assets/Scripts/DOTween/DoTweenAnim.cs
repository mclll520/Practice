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
* Filename: DoTweenAnim
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenAnim : MonoBehaviour {

    public Vector3 StartPos = new Vector3(10, 10, 10);
    public Transform CubeTransform;

    public float StartValue = 0;
	void Start () {
        // DOTween.To(() => StartPos, x => StartPos = x, new Vector3(0, 0, 0), 3);
        DOTween.To(() => StartValue, x => StartValue = x, 10, 3);
	}
	
	
	void Update () {
        //CubeTransform.position = StartPos;
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartValue = 0;
            DOTween.To(() => StartValue, x => StartValue = x, 10, 3);
        }
    }
}
