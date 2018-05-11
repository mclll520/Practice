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
* Filename: EasyTouch01
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using HedgehogTeam.EasyTouch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyTouch01 : MonoBehaviour {

	
	void OnEnable () {
        EasyTouch.On_TouchStart += OnTouchStart;
        EasyTouch.On_TouchUp += OnTouchEnd;
        EasyTouch.On_Swipe += OnSwipe;
	}
	
	
	void OnDisable () {
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnSwipe;
    }

    void OnDestroy()
    {
        EasyTouch.On_TouchStart -= OnTouchStart;
        EasyTouch.On_TouchUp -= OnTouchEnd;
        EasyTouch.On_Swipe -= OnSwipe;
    }


    void OnTouchStart(Gesture gesture) {
        Debug.Log("OnTouchStart");
        Debug.Log("StartPosition" + gesture.startPosition);
    }
    void OnTouchEnd(Gesture gesture)
    {
        Debug.Log("OnTouchEnd");
        Debug.Log("Actime" + gesture.actionTime);
    }
    void OnSwipe(Gesture gesture)
    {
        Debug.Log("OnSwipe");
        Debug.Log("Type" + gesture.swipe);
    }
}
