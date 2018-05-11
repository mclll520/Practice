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
* Filename: Text_010
* Created:  $time$
* Author:   WYC
* Purpose:  后台和前台 线程
* ==============================================================================
*/
using System;
using System.Threading;
using UnityEditor.VersionControl;
using UnityEngine;

public class Text_010 : MonoBehaviour {

	
	void Start ()
	{
        //Thread t = new Thread(DownLoadFiles);//这个是前台线程
        //t.IsBackground = true;//设置为后台线程
        //   t.Start("wangyuchen");
        //   t.Abort();
        //t.Join();


        //ThreadPool.QueueUserWorkItem(ThreadMethod);//开启一个工作线程
        //ThreadPool.QueueUserWorkItem(ThreadMethod);
        //ThreadPool.QueueUserWorkItem(ThreadMethod);
        //ThreadPool.QueueUserWorkItem(ThreadMethod);
        //ThreadPool.QueueUserWorkItem(ThreadMethod);
        //   ThreadPool.QueueUserWorkItem(ThreadMethod);
        //   ThreadPool.QueueUserWorkItem(ThreadMethod);

        //MyThreadObject m = new MyThreadObject();
        //Thread t = new Thread(ChangeState);
        //t.Start(m);
        //new Thread(ChangeState).Start(m);
    }

    private void ChangeState(object o)
    {
       MyThreadObject m =o as MyThreadObject;
        while (true)
        {
            lock (m)
            {
                m.ChangeState();
            }
           
        }
    }

    static void TaskMethote(Task a)
    {
        Debug.Log( "开始下载" + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Debug.Log("下载完成");
    }

    static void ThreadMethod(object obh)
    {
        print("线程开始" + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        print("线程结束");
    }


    private void DownLoadFiles(object obj)
    {
        Debug.Log(obj + "开始下载" + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Debug.Log("下载完成");
    }

}

class MyThreadObject
{
    private int state = 5;

    public void ChangeState()
    {
        state++;
        if (state==5)
        {
            Debug.Log("state==5");
        }
        state = 5;
    }
}
