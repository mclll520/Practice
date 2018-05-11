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
* Filename: Helloword04
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Helloword04 : MonoBehaviour {

	
	void Start ()
	{
	    LuaEnv lua = new LuaEnv();
        lua.DoString("require'XLua/CSharpCallLua'");
        //int a = lua.Global.Get<int>("a");//获取Lua里面的全局变量
        //   Debug.Log(a);
        //double aa = lua.Global.Get<double>("aa");//获取Lua里面的全局变量
        //Debug.Log(aa);
        //   string b = lua.Global.Get<string>("str");//获取Lua里面的全局变量
        //Debug.Log(b);
        //bool c = lua.Global.Get<bool>("isDie");//获取Lua里面的全局变量
        //Debug.Log(c);


        //Persons p = lua.Global.Get<Persons>("person");
        //Debug.Log(p.name + ":haha:" + p.age + "kankan" + p.age2);
        //p.name = "wangdaxain";//这里修改不会修改到lua源文件  （映射）
        //lua.DoString("print(person.name)");


        //IIPersons pp = lua.Global.Get<IIPersons>("person");
        //   print(pp.name + "sdfsdf" + pp.age);
        //   pp.name = "wangdaxain";//这里修改会修改到lua源文件  
        //   lua.DoString("print(person.name)");
        //pp.eat(345,23);
        lua.Dispose();
	}


    //class Persons
    //{
    //    public string name;
    //    public int age;
    //    public float age2;
    //}

    [CSharpCallLua]
    public interface IIPersons
    {
        string name { get; set; }
        int age { get; set; }
        void eat(int a,int b);
    }
}
