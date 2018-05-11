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
* Filename: Helloword03
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using XLua;

public class Helloword03 : MonoBehaviour {

	
	void Start () {
		LuaEnv lua = new LuaEnv();

        lua.AddLoader(MyLoader);
        //lua.DoString("require 'helloword'");

	    lua.DoString("require 'lua007'");
        

        lua.Dispose();
	}

    private byte[] MyLoader(ref string filepath)
    {
        //Debug.Log(filepath);
        //string s = "print('为啥是我')";
        //return Encoding.UTF8.GetBytes(s);

        string path = Application.streamingAssetsPath + "/" + filepath + ".lua.txt";
        return Encoding.UTF8.GetBytes(File.ReadAllText(path));
    }

    void Update () {
		
	}
}
