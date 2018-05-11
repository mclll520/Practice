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
* Filename: Text12
* Created:  $time$
* Author:   WYC
* Purpose:  部分类  密封类   接口类
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text12 : MonoBehaviour {

	
	void Start () {
        Xushen xushen = new Xushen();
        xushen.names();
        MyStudent myStudent = new MyStudent();
        myStudent.xiaojie();
    }
	
	
	void Update () {
		
	}
}
//部分类
public partial class Xushen
{
    private string _name;
}
public partial class Xushen
{
    public void names() {
        _name = "牛逼";
        Debug.Log(_name);
    }
}
//密封类 (不能被其他类继承)
public sealed class MiFeng :Xushen
{

}
//接口类
public class MyStudent : Xushen, JieKou
{
    public string wangyu(string name)
    {
        throw new System.NotImplementedException();
    }

    public void xiaojie()
    {
        Debug.Log("吃喝拉撒睡");
    }
}
public interface JieKou{
    void xiaojie();
    string wangyu(string name);
}