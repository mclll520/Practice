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
* Filename: NGUISkill
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NGUISkill : MonoBehaviour {

    public float ColdTime = 2;
    private UISprite _uISprite;
    private UILabel _uILabel;
    private bool _startCold = false;
    private float timer =0;
    void Start () {
        _uISprite = transform.Find("Sprite").GetComponent<UISprite>();
        _uILabel = transform.Find("UILabel").GetComponent<UILabel>();
    }
	
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.A)&&!_startCold)
        {
            _uISprite.fillAmount = 1;
            _startCold = true;
        }

        if (_startCold)
        {
            timer += Time.deltaTime;
            _uISprite.fillAmount -= (1f / ColdTime) * Time.deltaTime;
            _uILabel.text = Mathf.CeilToInt(ColdTime - timer).ToString();
            if (_uISprite.fillAmount<=0.05f)
            {
                timer = 0;
                _uILabel.text =null;
                _uISprite.fillAmount = 0;
                _startCold = false;
            }
        }




        

	}
}
