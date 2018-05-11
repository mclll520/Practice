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
* Filename: MyButton
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MyButton : MonoBehaviour {

    public RectTransform rectTransform;

    private bool IsIn = false;
    private void Start()
    {
        transform.GetComponent<Button>().onClick.AddListener(OnClick);
        //rectTransform.DOMove(new Vector3(0, 0, 0), 1);//(世界坐标)
        Tweener tweener = rectTransform.DOLocalMove(new Vector3(0, 0, 0), 2);//（当地坐标）                                                                    //不让他自动销毁
        tweener.SetAutoKill(false);
        tweener.Pause();
    }

    public void OnClick() {
        IsIn = !IsIn;
        if (IsIn)
        {
            rectTransform.DOPlayForward();
        }
        else
        {
            rectTransform.DOPlayBackwards();
        }
      
    }
}
