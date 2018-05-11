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
* Filename: MyText
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.IO;
using System.Text;

public class MyText : MonoBehaviour {

    private Text text;
	
	void Start () {
        text = transform.GetComponent<Text>();
        string str;
        using (FileStream fsRead =new FileStream (@"C:\Users\Administrator.PC-201709211725\Desktop\王.txt",FileMode.Open,FileAccess.Read) ) {
            byte[] butter = new byte[1024 * 1024 * 5];
            int r = fsRead.Read(butter, 0, butter.Length);
            str = Encoding.Default.GetString(butter, 0, r);
        }
        Tweener tweener = text.DOText(str, 12);
        tweener.OnComplete(OnColor);
	}

    private void OnColor()
    {
        text.DOColor(new Color(0,0,0,1), 4);
        text.DOFade(0, 8);
    }

    void Update () {
		
	}
}
