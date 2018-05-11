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
* Filename: TransparentControl
* Created:  $time$
* Author:   WYC
* Purpose:  透明动画控制
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentControl : MonoBehaviour {
    private Color _materialColor;
    public Color color = new Color(0, 0, 0, 0.5f);
    private bool IsColor;
    void Start()
    {
        _materialColor = this.GetComponent<Renderer>().material.color;
    }

    void Alpha() {
        if (_materialColor.a >0.95f)
        {
            IsColor = true;
        }
        if (_materialColor.a < 0.05f)
        {
            IsColor = false;
        }
        if (IsColor)
        {
            _materialColor -= color * Time.deltaTime ;
        }
        else
        {
            _materialColor += color * Time.deltaTime;
        }
        this.GetComponent<Renderer>().material.color = _materialColor;
    }

    void Update()
    {
        Alpha();
    }
}
