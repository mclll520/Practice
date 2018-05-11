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
* Filename: Text_009
* Created:  $time$
* Author:   WYC
* Purpose:  Thread 发起线程
* ==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Text_009 : MonoBehaviour {

	
	void Start () {
        //Thread t =new Thread(DownLoadFile);
        //      t.Start();//开始线程

        //Thread t = new Thread(() =>
        //{
        //    Debug.Log("开始下载" + Thread.CurrentThread.ManagedThreadId);
        //    Thread.Sleep(2000);
        //    Debug.Log("下载完成");
        //   });
        //t.Start();//开始线程


        //Thread t = new Thread(DownLoadFiles);
        //t.Start("xxx.种子");//开始线程


	    MyThread my = new MyThread("xxx.sbt", "www.baidu.com");
	    Thread t = new Thread(my.DownFile);
	    t.Start();//开始线程
        Debug.Log("执行完毕");
	}

    private void DownLoadFiles(object obj)
    {
        Debug.Log(obj+"开始下载" + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Debug.Log("下载完成");
    }

    private void DownLoadFile()
    {
        Debug.Log("开始下载"+Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(2000);
        Debug.Log("下载完成");
    }

}

class MyThread
{
    private string filename;
    private string filepath;

    public MyThread(string fileName, string filePath)
    {
        this.filename = fileName;
        this.filepath = filePath;
    }

    public void DownFile()
    {
        Debug.Log(filename+"开始下载" + Thread.CurrentThread.ManagedThreadId + filepath);
        Thread.Sleep(2000);
        Debug.Log("下载完成");
    }
}