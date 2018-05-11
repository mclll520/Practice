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
* Filename: testcubeScript
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcubeScript : MonoBehaviour
{

    private Animator anim;
    private int Newnums = 2;

    void Start ()
	{
	    anim = GetComponent<Animator>();
	    anim.SetBool("cube" + Newnums, true);
    }

 

    public void CloseAnim(string name)
    {
        anim.SetBool(name, false);
        Newnums = Random.Range(0, 8);
        anim.SetBool("cube" + Newnums, true);
    }

    public void Finish()
    {
        anim.SetBool("cube" + Newnums, false);
    }

   

    void Update()
    {
       
    }

}
