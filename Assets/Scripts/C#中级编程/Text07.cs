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
* Filename: Text07
* Created:  $time$
* Author:   WYC
* Purpose:  StreamReader 和 StreamWriter 简单调用
* ==============================================================================
*/
using System.Text;
using System.IO;
using UnityEngine;

public class Text07 : MonoBehaviour {


    void Start() {
        //StreamReader();
        //StreamWriter();
        //StreamWriterApp();
    }
    /// <summary>
    /// 读取一个文本文件
    /// </summary>
    public void StreamReader(){
        using (StreamReader sr = new StreamReader(@"C:\Users\Administrator.PC-201709211725\Desktop\王.txt", Encoding.Default))
        {
            while (!sr.EndOfStream)
            {
                //只读取第一行
                print(sr.ReadLine());
            }
        }
    }
    /// <summary>
    /// 写入一个文本文件 (覆盖)
    /// </summary>
    public void StreamWriter()
    {
        using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator.PC-201709211725\Desktop\王.txt"))
        {
            sw.Write("我真帅");
            print("写入OK");
        }
    }
    /// <summary>
    /// 写入一个文本文件 (未覆盖)
    /// </summary>
    public void StreamWriterApp()
    {
        using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator.PC-201709211725\Desktop\王.txt",true))
        {
            sw.Write("你真帅");
            print("写入OK");
        }
    }
}
