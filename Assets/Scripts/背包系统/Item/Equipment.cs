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
* Filename: Equipment
* Created:  $time$
* Author:   WYC
* Purpose:  装备类型
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item {
    // 力量 智力 敏捷 体力
    public int Strength { set; get; }
    public int Intellect { set; get; }
    public int Agility { set; get; }
    public int Stamina { set; get; }

    public EquipmentType EquipmentTypes { set; get; }

    public Equipment(int id, string name, ItemType itemType, Quality quality, string description, int capacity, int buyPrice,
        int sellprice, string sprite,int strength,int intellect,int agility,int Stamina,EquipmentType equipmentTypes) :base(id, name, itemType, quality, description, capacity, buyPrice, sellprice, sprite)
    {
        this.Strength = strength;
        this.Agility = agility;
        this.Intellect = intellect;
        this.Stamina = Stamina;
        this.EquipmentTypes = equipmentTypes;
    }

    public enum EquipmentType
    {
        Head,
        Neck,
        Ring,
        Leg,
        Bracer,Boots,
        Trinket,
        Shoulder,
        Belt,
        OffHand
    }
}
