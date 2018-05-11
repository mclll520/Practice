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
* Filename: Consumable
* Created:  $time$
* Author:   WYC
* Purpose:  消耗品类
* ==============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item {
    public int HP { set; get; }
    public int MP { set; get; }

    public Consumable(int id, string name, ItemType itemType, Quality quality, string description, int capacity, int buyPrice,
        int sellprice, string sprite,int hp,int mp):base(id,name,itemType,quality,description,capacity,buyPrice,sellprice,sprite)
    {
        this.HP = hp;
        this.MP = mp;
    }

    public override string ToString()
    {
        string s = "";
        s += "编号：" + Id;
        s += " 类型：" + Type;
        s += " 品质：" + Qualitys;
        s += " 内容：" + Description;
        s += " 数量：" + Capacity;
        s += " 购买值：" + BuyPrice;
        s += " 贩卖值：" + Sellprice;
        s += " 图形：" + Sprite;
        s += " 血量：" + HP;
        s += " 蓝量：" + MP;
        return s;
    }

 
}
