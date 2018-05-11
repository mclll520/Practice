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
* Filename: MyPanle2
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyPanle2 : MonoBehaviour {
    private DOTweenAnimation _tweenAnim;
    private bool _isOn = true;
	void Start () {
        _tweenAnim = transform.GetComponent<DOTweenAnimation>();
        //_tweenAnim.DOPlay();
	}

    public void OnClick() {
        _isOn = !_isOn;
        if (_isOn)
        {
            _tweenAnim.DOPlayBackwards();
        }
        else
        {
            _tweenAnim.DOPlayForward();
        }

    }

	void Update () {
		
	}
}
