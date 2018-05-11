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
* Filename: DropItem
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : UIDragDropItem {


    protected override void OnDragDropRelease(GameObject surface)
    {
        base.OnDragDropRelease(surface);
        Debug.Log(surface);
        if (surface ==null || surface.tag =="UIRoot")
        {
            transform.localPosition = Vector3.zero;
        }
        else if (surface.tag =="cell")
        {
            transform.parent = surface.transform;
            transform.localPosition = Vector3.zero;
        }
        else
        {
            Transform temp = surface.transform.parent;
            surface.transform.parent = transform.parent;
            transform.parent = temp;
            surface.transform.localPosition = Vector3.zero;
            transform.localPosition = Vector3.zero;
        }
    }
}
