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
* Filename: Text_002
* Created:  $time$
* Author:   WYC
* Purpose:  正则表达式
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Text_002 : MonoBehaviour {

	
	void Start ()
	{
	    string s = "I am blue cat";
        //搜索字符串 符合正则表达式的情况下 然后把所有符合的位置 替换成后面的字符串 （用来定位的）
        print(Regex.Replace(s, "^", "开始你的表演："));
	    print(Regex.Replace(s, "$", "结束你的表演："));

        StringNumber("wadaw");
	    StringNumber("123456");

        //他代表一个字符串 除了abc之外的任意字符
        string s1 = "I am blue cat";
	    string pattern = @"[^abc]";
        print(Regex.Replace(s1, pattern, "#"));

        //重复描述字符(检验QQ号是否是合法QQ)
	    string QQ1 = "213421";
	    string QQ2 = "2134235464564564561";
	    string QQ3 = "w21213421";
	    string pattern1 = @"^\d{5,12}$";
        print(Regex.IsMatch(QQ1,pattern1));
	    print(Regex.IsMatch(QQ2, pattern1));
	    print(Regex.IsMatch(QQ3, pattern1));

        //择一匹配
	    string s2 = "2342([]#$asdas%速度快解放三";
	    string pattern2 = @"\d|[a-z]";
	    MatchCollection col = Regex.Matches(s2, pattern2);
	    foreach (Match match in col)
	    {
	        print(match.ToString());
	    }

	    string s3 = "张三;李四,王二.刘大";
	    string pattern3 = @"[;]|[,]|[.]";
	    string [] resArray = Regex.Split(s3, pattern3);
	    foreach (string s4 in resArray)
	    {
	        print(s4);
	    }
	}

    /// <summary>
    /// 当前字符串是不是数字字符
    /// </summary>
    /// <param name="str"></param>
    public void StringNumber(string str)
    {

        bool isMastch = true;
        //@第一种
        //for (int i = 0; i < str.Length; i++)
        //{
        //    if (str[i]<'0'||str[i]>'9')
        //    {
        //        isMastch = false;
        //        break;
        //    }
        //}
       
        //@第二种（正则表达式）
        string pattern = @"^\d*$";
        isMastch = Regex.IsMatch(str,pattern);

        if (isMastch)
        {
            print("合法数字字符");
        }
        else
        {
            print("不合法数字字符");
        }
    }

    void Update () {
		
	}
}
