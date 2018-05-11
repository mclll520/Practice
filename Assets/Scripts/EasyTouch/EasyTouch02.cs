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
* Filename: EasyTouch02
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

public class EasyTouch02 : MonoBehaviour {


    public void printNum(int num) {
        Debug.Log(num);
    }

    public void PrintMsg(GameObject go) {
        if (go == null)
        {
            Debug.Log("null");
        }
        else
        {
            Debug.Log(go.name);
        }
    }

    public void printOk() {
        Debug.Log("OK");
    }


    public void SpeedUp()
    {
        Debug.Log("加速");
    }
    public void SpeedDown()
    {
        Debug.Log("减速");
    }

    private void Update()
    {
        Gesture gesture = EasyTouch.current;
        if (gesture !=null && gesture.swipe == EasyTouch.SwipeDirection.Up)
        {
            Debug.Log(gesture.swipe);
        }
        if (gesture != null && gesture.swipe == EasyTouch.SwipeDirection.Down)
        {
            Debug.Log(gesture.swipe);
        }
        if (gesture != null && gesture.swipe == EasyTouch.SwipeDirection.Left)
        {
            Debug.Log(gesture.swipe);
        }
        if (gesture != null && gesture.swipe == EasyTouch.SwipeDirection.Right)
        {
            Debug.Log(gesture.swipe);
        }
        if (ETCInput.GetButtonUp("SpeedButton"))
        {
            Debug.Log("加速");
        }
        if (ETCInput.GetButtonDown("SpeedButton"))
        {
            Debug.Log("减速");
        }
    }
}
