﻿/*              #########                       
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
* Filename: NGUIAgeLimit
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGUIAgeLimit : MonoBehaviour {
    private UIInput uIInput;
	
	void Start () {
        uIInput = transform.GetComponent<UIInput>();
	}
    public void OnAgeValueChange() {
        string value = uIInput.value;
        int valuInt = int.Parse(value);
        if (valuInt <18)
        {
            uIInput.value = "18";
        }
        if (valuInt >120)
        {
            uIInput.value = "120";
        }
    }
	
	void Update () {
	
	}
}