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
* Filename: Inventory
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{



    private Slot[] slotlList;
	
	public virtual void Start ()
	{
	    slotlList = GetComponentsInChildren<Slot>();
	}


    public bool StoreItem(int id)
    {
        Item item = InventoryManager.Instance.GetItemById(id);
        if (item == null)
        {
            Debug.LogWarning("要储存的物品ID不存在");
            return false;
        }
        if (item.Capacity ==1)
        {
            Slot slot = FindEmptSlot();
            if (slot == null)
            {
                Debug.LogWarning("没有空的物品槽");
                return false;
            }
            else
            {
               slot.StoreItem(item);
            }
           
        }
        else
        {
            Slot slot = FindSameTypeSlot(item);
            if (slot!=null)
            {
                slot .StoreItem(item);
            }
            else
            {
                Slot emptySlot = FindEmptSlot();
                if (emptySlot != null)
                {
                    emptySlot.StoreItem(item);
                }
                else
                {
                    Debug.LogWarning("没有空的物品槽");
                    return false;
                }
            }
        }
        return true;

    }
    /// <summary>
    /// 找有没有空的物品槽
    /// </summary>
    /// <returns></returns>
    private Slot FindEmptSlot()
    {
        foreach (Slot slot in slotlList)
        {
            if (slot.transform.childCount == 0)
            {
                return slot;
            }
        }
        return null;
    }

    private Slot FindSameTypeSlot(Item item)
    {
        foreach (Slot slot in slotlList)
        {
            if (slot.transform.childCount>=1  && slot.GetItemType()==item.Type && slot.IsFilled() == false)
            {
                return slot;
            }
        }
        return null;
    }
}
