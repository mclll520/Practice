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
* Filename: SoldierIdleState
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierIdleState : ISoldierState {

    public SoldierIdleState(SoldierFSMSytem fsm, ICharacter c) : base(fsm, c)
    {
        stateID = SoldierStateID.Idle;
    }

    public override void Act(List<ICharacter> targets)
    {
        character.PlayAnim("stand");
    }

    public override void Reason(List<ICharacter> targets)
    {
        if (targets!=null && targets.Count >0)
        {
            FSM.PerFormTransition(SoldierTransition.SeeEnemy);
        }
    }
}
