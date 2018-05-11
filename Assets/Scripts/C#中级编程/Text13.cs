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
* Filename: Text13
* Created:  $time$
* Author:   WYC
* Purpose:  接口
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text13 : MonoBehaviour {

	
	void Start () {
        Cars cars = new Cars();
        cars.Text1();
        cars.Text2();
        cars.Text3();
        cars.Text4();

        IFlayble flayble = new Bird();
        flayble.Fly();
        Bird bird = new Bird();
        bird.Fly();


        IInterfaceDake interfaceDake = new ReaDuak();
        interfaceDake.Swiming();
        IInterfaceDake interfaceDake1 = new MuDuak();
        interfaceDake1.Swiming();
        IInterfaceDake interfaceDake2 = new XPDuak();
        interfaceDake2.Swiming();


    }
	
	
	

}
public interface M1
{
    void Text1();
}
public interface M2
{
    void Text2();
}

public interface M3
{
    void Text3();
}
public interface M4
{
    void Text4();
}
public interface SupperInterface : M1, M2, M3, M4
{
    
}
public class Cars : SupperInterface
{
    public void Text1()
    {
        Debug.Log("战斗机1");
    }

    public void Text2()
    {
        Debug.Log("战斗机2");
    }

    public void Text3()
    {
        Debug.Log("战斗机3");
    }

    public void Text4()
    {
        Debug.Log("战斗机4");
    }
}

public class Bird:IFlayble
{
    public void Fly() {
        Debug.Log("鸟在飞");
    }
    /// <summary>
    /// 显示实现接口
    /// </summary>
    void IFlayble.Fly() {
        Debug.Log("自己在飞");
    }
}
public interface IFlayble {
    void Fly();
}

public class ReaDuak : IInterfaceDake
{
    public void Swiming()
    {
        Debug.Log("真鸭子");
    }
}
public class MuDuak : IInterfaceDake
{
    public void Swiming()
    {
        Debug.Log("木鸭子");
    }
}
public class XPDuak : IInterfaceDake
{
    public void Swiming()
    {
        Debug.Log("橡鸭子");
    }
}
public interface IInterfaceDake
{
    void Swiming();
}
