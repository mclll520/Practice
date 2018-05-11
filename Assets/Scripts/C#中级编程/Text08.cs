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
* Filename: Text08
* Created:  $time$
* Author:   WYC
* Purpose:  多态
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text08 : MonoBehaviour {

	
	void Start () {
        Chineses c1 = new Chineses("张三");
        Chineses c2 = new Chineses("李四");
        Japanese j1 = new Japanese("松下君");
        Japanese j2 = new Japanese("靖边君");
        Korea k1 = new Korea("金秀贤");
        Korea k2 = new Korea("金成柱");
        American a1 = new American("大伟乔布斯");
        American a2 = new American("马克杰克逊");
        Persons[] per = { c1, c2, j1, j2, k1, k2, a1, a2 };
        for (int i = 0; i < per.Length; i++)
        {
            per[i].SayHello();
        }
    }
	
	
	
}

public class Persons
{
    private string _name;
    public string Name {
        get { return _name; }
        set { _name = value; }
    }
    public Persons(string name) {
        this.Name = name;
    }
    public virtual void SayHello() {
        Debug.Log("我是人类");
    }
}
public class Chineses : Persons
{
    public Chineses(string name) : base(name) {

    }
    public override void SayHello()
    {
        Debug.Log("我是中国人，我是"+Name);
    }
}
public class Japanese : Persons
{
    public Japanese(string name) : base(name)
    {

    }
    public override void SayHello()
    {
        Debug.Log("我是小鬼子，我是" + Name);
    }
}
public class Korea : Persons
{
    public Korea(string name) : base(name)
    {

    }
    public override void SayHello()
    {
        Debug.Log("我是棒子国，我是" + Name);
    }
}
public class American : Persons
{
    public American(string name) : base(name)
    {

    }
    public override void SayHello()
    {
        Debug.Log("我是美国人，我是" + Name);
    }
}
