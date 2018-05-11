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
* Filename: InventoryManager
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InventoryManager : MonoBehaviour
{

    #region 单利模式 
    private static InventoryManager _instance;

    public static InventoryManager Instance
    {
        get
        {
            if (_instance == null)
            {
                //这个代码只会出现一次
                _instance = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
            }
            return _instance;
        }
    }
    #endregion

    void Start()
    {
        ParseItemJosn();
        
    }

    private List<Item> itemList;
    /// <summary>
    /// 解析物品信息
    /// </summary>
    void ParseItemJosn()
    {
        itemList =new List<Item>();
        //文本在unity里面是TextAsset类型
        TextAsset itemText = Resources.Load<TextAsset>("Json/Item");

        JSONObject j =new JSONObject(itemText.text);
        foreach (JSONObject temp in j.list)
        {
            Item.ItemType type = (Item.ItemType)System.Enum.Parse(typeof(Item.ItemType), temp["type"].str);
             
            //共有属性
            int id = (int) (temp["id"].n);
            string name = temp["name"].str;
            Item.Quality qualitys = (Item.Quality)System.Enum.Parse(typeof(Item.Quality), temp["qualitys"].str);
            string description = temp["description"].str;
            int capacity = (int)(temp["capacity"].n);
            int buyPrice = (int)(temp["buyPrice"].n);
            int sellprice = (int)(temp["sellprice"].n);
            string sprite = temp["sprite"].str;

            Item item = null;

            switch (type)
            {
                case Item.ItemType.Consunable:
                    int hp = (int)(temp["hp"].n);
                    int mp = (int)(temp["mp"].n);
                    item = new Consumable(id,name,type,qualitys,description,capacity,buyPrice,sellprice,sprite,hp,mp);
                    break;
                case Item.ItemType.Eqipment:
                    break;
                case Item.ItemType.Weapon:
                    break;
                case Item.ItemType.Material:
                    break;
            }

            itemList.Add(item);
            Debug.Log(item.ToString());

        }


    }

    /// <summary>
    /// 根据id返回物品
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Item GetItemById(int id)
    {
        foreach (Item item in itemList)
        {
            if (item.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}
