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
* Filename: Text11
* Created:  $time$
* Author:   WYC
* Purpose:  序列化和反序列化
* ==============================================================================
*/
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Text11 : MonoBehaviour {

	
	void Start () {
        //BinaryFormatterWrite();
        //BinaryFormatterRead();
    }
    public void BinaryFormatterRead()
    {
        PerSonqwer p = new PerSonqwer();
        using (FileStream fsRead = new FileStream(@"C:\Users\Administrator.PC-201709211725\Desktop\王1.txt", FileMode.OpenOrCreate, FileAccess.Read))
        {
            //开始反序列化
            BinaryFormatter bf = new BinaryFormatter();
            p = (PerSonqwer) bf.Deserialize(fsRead);
        }
        print("反序列化");
        print(p.Name);
        print(p.Age);
        print(p.Gender);
    }


    public void BinaryFormatterWrite() {
        PerSonqwer p1 = new PerSonqwer();
        p1.Name = "张三";
        p1.Age = 21;
        p1.Gender = "男";
        using (FileStream fsWrite = new FileStream(@"C:\Users\Administrator.PC-201709211725\Desktop\王1.txt", FileMode.OpenOrCreate, FileAccess.Write))
        {
            //开始序列化
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fsWrite, p1);
            print("序列化");
        }
    }


    void Update () {
		
	}
}
[Serializable]
public class PerSonqwer
{
    public string Name;
    public int Age;
    public string Gender;
}
