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
* Filename: ItemPBag
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPBag : MonoBehaviour {
    Transform BG;
    GameObject Pack;

    void Start () {
        Pack = Resources.Load<GameObject>("Pack");
	}
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
             for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.GetChild(i).childCount == 1)
                {
                    NGUITools.AddChild(transform.GetChild(i).gameObject, Pack);
                    
                    break;
                }
                else {
                    if (transform.GetChild(i).GetChild(1).name == Pack.name)
                    {
                        string num = transform.GetChild(i).GetComponentInChildren<UILabel>().text;
                        if (num==null)
                        {
                            transform.GetChild(i).GetComponentInChildren<UILabel>().text = "1";
                        }
                        else
                        {
                            int a;
                            int.TryParse(num, out a);
                            a += 1;
                            transform.GetChild(i).GetComponentInChildren<UILabel>().text = a.ToString();
                            break;
                        }
                    }
                }
            }
        }
	}
}
