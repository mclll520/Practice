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
* Filename: GAmeLoop
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour {
    //启动
    private SceneStateController _controller = null;

    void Awake() {
        //不要删除他
        DontDestroyOnLoad(this.gameObject);
    }

	void Start () {
        //创建出来
        _controller = new SceneStateController();
        _controller.SetState(new StartState(_controller),false);

        //测试
        ICharacter character = new SoldierCaptain();
        //WeaponGun gun = new WeaponGun();
        //character._gun = gun;

        //WeaponRifle rifle = new WeaponRifle();
        //character._rifle = rifle;

        //WeaponRocket weaponRocket = new WeaponRocket();
        //character.weapon = new WeaponRifle();
        //character.Attack(Vector3.one); 


	}
	
	
	void Update () {
        _controller.StateUpdate();
	}
}
