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
* Filename: Text_005
* Created:  $time$
* Author:   WYC
* Purpose:  观察者模式
* ==============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_005 : MonoBehaviour {

	
	void Start () {
	    //观察者模式
	    //Cate cate = new Cate("加菲猫", "黄色");
	    //Mouse mouse1 = new Mouse("米奇", "黑色", cate);
	    //Mouse mouse2 = new Mouse("蓝皮鼠", "蓝色", cate);
	    //Mouse mouse3 = new Mouse("黑皮鼠", "澄色", cate);
	    //cate.CateAction();

	}
	
	

}
class Cate
{
    private string Name;
    private string Color;

    public Cate(string name, string color)
    {
        Name = name;
        Color = color;
    }
    //public void CateAction(Mouse mouse1, Mouse mouse2)
    public void CateAction()
    {
        Debug.Log(Color + Name + "进屋里,喵喵喵");
        //mouse1.MouseAction();
        //mouse2.MouseAction();
        if (CatCome != null)
        {
            CatCome();
        }
    }

    public event Action CatCome;
}

class Mouse
{
    private string Name;
    private string Color;

    public Mouse(string name, string color, Cate cate)
    {
        Name = name;
        Color = color;
        cate.CatCome += MouseAction;
    }
    public void MouseAction()
    {
        Debug.Log(Color + Name + "大叫到,快跑快跑");
    }
}
