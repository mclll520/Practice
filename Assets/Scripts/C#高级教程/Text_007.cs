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
* Filename: Text_007
* Created:  $time$
* Author:   WYC
* Purpose:  反射和特性
* ==============================================================================
*/

#define IsText  //定义一个宏
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Text_007 : MonoBehaviour {

	
	void Start () {
		//MyClass myClass = new MyClass();
	 //   Type type = myClass.GetType();
  //      Debug.Log(type.Name);
	 //   Debug.Log(type.Namespace);
	 //   Debug.Log(type.Assembly);
	 //   FieldInfo[] info = type.GetFields();//只能获得Public字段
	 //   foreach (FieldInfo f in info)
	 //   {
	 //       Debug.Log(f.Name);
  //      }
	 //   PropertyInfo[] info1 = type.GetProperties();//只能获得Public字段
	 //   foreach (PropertyInfo f in info1)
	 //   {
	 //       Debug.Log(f.Name);
	 //   }
	 //   MethodInfo[] info3 = type.GetMethods();//只能获得Public字段
	 //   foreach (MethodInfo f in info3)
	 //   {
	 //       Debug.Log(f.Name);
	 //   }


     //   MyClass my =new MyClass();
	    //Assembly ass = my.GetType().Assembly;
     //   Debug.Log(ass.FullName);
	    //Type[] types = ass.GetTypes();
	    //foreach (Type t in types)
	    //{
	    //    print(t);
	    //}
        oldMethod();
	    NewdMethod();


	}


    //  [Obsolete("这个已经被弃用")]//已经被弃用
    static void oldMethod()
    {
        Debug.Log("oldMethod");
    }
    [Conditional("IsText")] //隐藏方法
    static void NewdMethod()
    {
        Debug.Log("NewdMethod");
    }

  
}

