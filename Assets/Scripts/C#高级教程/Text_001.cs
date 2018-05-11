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
* Filename: Text_001
* Created:  $time$
* Author:   WYC
* Purpose:  字符串 string StringBuilder
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Text_001 : MonoBehaviour {

	
	void Start () {
        string s = "www.baidu.com";
        print(s[2]);

        print(s.Split('.')[1]);
        print(s.Substring(4,7));
        print(s.Length);//长度
        print(s.ToLower());
        print(s.ToUpper());
        string s1 = "DaLao";
        print(s1.CompareTo("Da"));
        Debug.Log(s1.Replace("D", "111"));
        //1.
//        StringBuilder sb = new StringBuilder("wwww.baidu.com");
        //2.初始一个空的stringbuilder对象 占有20个字符串的大小
//	    StringBuilder sb1 = new StringBuilder(20);
        //3.
        StringBuilder sb2 =new StringBuilder("wwww.baidu.com",100);
        print(sb2.Replace('.','_'));
	    print(sb2.Append("/wangyuchen"));
	   
	    sb2.Remove(0, 5);

	    print(sb2.Insert(0, "http://"));

	    string ss = sb2.ToString();
        Debug.Log(ss);
	}
	
	
	
}
