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
* Filename: Text_011
* Created:  $time$
* Author:   WYC
* Purpose:  socket_Tcp协议_客户端
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Text_011 : MonoBehaviour {

	
	void Start ()
	{
        //创建Socket
	    Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //建立连接的请求
	    IPAddress ipAddress =IPAddress.Parse("192.168.2.224");

        EndPoint point = new IPEndPoint(ipAddress,8080);
	    tcpSocket.Connect(point);

        byte[] bytes=new byte[1024*1024];
	    int length = tcpSocket.Receive(bytes);

	    string message = Encoding.Default.GetString(bytes, 0, length);
        Debug.Log(message);


	}
	
	
	void Update () {
		
	}
}
