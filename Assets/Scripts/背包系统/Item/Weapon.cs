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
* Filename: Weapon
* Created:  $time$
* Author:   WYC
* Purpose:  武器类
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item {
    public int Damage { get; set; }

    public WeaponType WeaponTypes { set; get; }

    public Weapon(int id, string name, ItemType itemType, Quality quality, string description, int capacity, int buyPrice,
        int sellprice,string sprite, WeaponType weaponType,int damage) : base(id, name, itemType, quality, description, capacity, buyPrice, sellprice, sprite)
    {
        this.Damage = damage;
        this.WeaponTypes = weaponType;
    }

    public enum WeaponType
    {
        OffHand,
        MainHand
    }
}
