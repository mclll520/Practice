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
* Filename: Text_004
* Created:  $time$
* Author:   WYC
* Purpose:  匿名方法
* ==============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_004 : MonoBehaviour
{

    public delegate void MyDelegate();

    //public MyDelegate myDelegate;
    public event MyDelegate myDelegate;


    static void Text1()
    {
        print("text1");
    }

    void Start ()
	{
	    Text_004 p = new Text_004();
	    p.myDelegate = Text1;
	    p.myDelegate();
	    //Func<int, int, int> pusFunc = Text1;
	    //print(pusFunc(23, 32));
        //修改成匿名方法
	    //Func<int, int, int> pusFunc = delegate(int arg1, int arg2)
	    //{
	    //    return arg1 + arg2;
	    //};

        //lambda表达式
	    Func<int, int, int> func = (arg1, arg2) =>
	    {
	        return arg1 + arg2;
	    };
        print(func(33,66)); 
	    Func<int, int> func1 = a => a+a;
	    print(func1(233));
     //   //观察者模式
	    //Cate cate = new Cate("加菲猫", "黄色");
	    //Mouse mouse1 = new Mouse("米奇", "黑色");
	    //cate.CatCome += mouse1.MouseAction;
	    //Mouse mouse2 = new Mouse("蓝皮鼠", "蓝色");
	    //cate.CatCome += mouse2.MouseAction;
	    //Mouse mouse3 = new Mouse("黑皮鼠", "澄色");
	    //cate.CatCome += mouse3.MouseAction;
     //   cate.CateAction();

        //cate.CateAction(mouse1,mouse2);
    }

    private int Text1(int arg1, int arg2)
    {
        return arg1 + arg2;
    }

}


