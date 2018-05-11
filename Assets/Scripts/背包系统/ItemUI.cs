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
* Filename: ItemUI
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour {


    public Item Item { get; set; }
    public int Amout { get; set; }

    public Image ItemImage
    {
        get
        {
            if (itemImage == null)
            {
                itemImage = GetComponent<Image>();
            }
            return itemImage;
        }
    }

    public Text AmoutText
    {
        get
        {
            if (amoutText == null)
            {
                amoutText = GetComponentInChildren<Text>();
            }
            return amoutText;
        }
    }

    private Image itemImage;
    private Text amoutText;



   



    public void SetItem(Item item, int amout = 1)
    {
        Item = item;
        Amout = amout;
        //
        ItemImage.sprite = Resources.Load<Sprite>(item.Sprite);
        AmoutText.text = Amout.ToString();
    }

    public void AddAmout(int amout = 1)
    {
        Amout += amout;
        AmoutText.text = Amout.ToString();
        //
    }

}
