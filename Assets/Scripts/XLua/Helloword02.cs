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
* Filename: Helloword02
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Helloword02 : MonoBehaviour {

	
	void Start ()
	{
	    TextAsset at = Resources.Load<TextAsset>("XLua/helloword.lua");

	    LuaEnv lua = new LuaEnv();
	    //lua.DoString("require 'helloword'");
	    lua.DoString(at.text);
	  
        lua.Dispose();
	}
	
	
	void Update () {
		
	}
}
