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
* Filename: Item
* Created:  $time$
* Author:   WYC
* Purpose:  物品基类
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
    public int Id { get; set; }
    public string Name { set; get; }

    public ItemType Type { set; get; }
    public Quality Qualitys { set; get; }

    public string Description { set; get; }
    public int Capacity { set; get; }
    public int BuyPrice { set; get; }
    public int Sellprice { set; get; }
    public string Sprite { set; get; }

    public Item()
    {
        this.Id = -1;
    }

    public Item(int id, string name, ItemType itemType, Quality quality, string description, int capacity, int buyPrice,
        int sellprice,string sprite)
    {
        this.Id = id;
        this.Name = name;
        this.Type = itemType;
        this.Qualitys = quality;
        this.Description = description;
        this.Capacity = capacity;
        this.BuyPrice = buyPrice;
        this.Sellprice = sellprice;
        this.Sprite = sprite;
    }

    /// <summary>
    /// 物品类型
    /// </summary>
    public enum ItemType
    {
        Consunable,
        Eqipment,
        Weapon,
        Material
    }
    /// <summary>
    /// 品质
    /// </summary>
    public enum Quality
    {
       Common,
       Unmmon,
       Rare,
       Epic,
       Legendary,
       Aetifact
    }

}
