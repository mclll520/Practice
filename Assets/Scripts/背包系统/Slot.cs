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
* Filename: Slot
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

    public GameObject ItemPrefab;

    /// <summary>
    /// 吧item放在自身下面 
    /// 如果自身下有这个item了  就amout++
    /// 如果没有  根据itemprefab去实例化一个item
    /// </summary>
    /// <param name="item"></param>
    public void StoreItem(Item item)
    {
        if (transform .childCount == 0)
        {
            GameObject itemGameObject = Instantiate(ItemPrefab) as GameObject;
            itemGameObject.transform.SetParent(transform);
            itemGameObject.transform.localPosition = Vector3.zero;
            itemGameObject.GetComponent<ItemUI>().SetItem(item);
        }
        else
        {
            transform .GetChild(0).GetComponent<ItemUI>().AddAmout();
        }
    }
    /// <summary>
    /// 得到当前物品草储存物品的类型
    /// </summary>
    public Item.ItemType GetItemType()
    {
        return transform.GetChild(0).GetComponent<ItemUI>().Item.Type;
    }
    /// <summary>
    /// 判断当前数量大于等于容量
    /// </summary>
    /// <returns></returns>
    public bool IsFilled()
    {
        ItemUI itemUi = transform.GetChild(0).GetComponent<ItemUI>();
        return itemUi.Amout >= itemUi.Item.Capacity;
    }
}
