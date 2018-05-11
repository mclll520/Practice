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
* Filename: Text_008
* Created:  $time$
* Author:   WYC
* Purpose:  进程  和  线程
* ==============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Text_008 : MonoBehaviour {
    static int Text1(int i)
    {
        Debug.Log("text1"+i);
        Thread.Sleep(100);//线程延迟睡眠
        return i*i;
    }

    void Start()
    {
        //1 通过委托 开启一个线程
        Func<int, int> a = Text1;
        //开启一个新的线程去执行  a所引用的方法
        //IAsyncResult ar = a.BeginInvoke(100, null, null);
        //可以认为同步执行的 （异步加载）
        Debug.Log("Start");
        //while (ar.IsCompleted==false)//判断当前线程是否执行完毕
        //{
        //    Debug.Log("..");
        //}
        //int ii = a.EndInvoke(ar);//取得异步线程返回值
        //Debug.Log(ii);

        //检测线程结束
        //bool isEnd = ar.AsyncWaitHandle.WaitOne(1000); //如果等待超过1000毫秒 线程还没结束  返回false
        //if (isEnd)
        //{
        //    int ii = a.EndInvoke(ar); //取得异步线程返回值
        //    Debug.Log(ii);
        //}

        //通过回调  检测线程结束
        // IAsyncResult ar1 = a.BeginInvoke(100, OnBack, a);

        //lambda表达式
        a.BeginInvoke(100, aa =>
        {
            int ret = a.EndInvoke(aa);
            print(ret);
        }, a);
    }

    private void OnBack(IAsyncResult ar)
    {
        Func<int, int> a = ar.AsyncState as Func<int, int>;
        print(a.EndInvoke(ar));
    }
}
