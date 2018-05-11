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
* Filename: Text_013
* Created:  $time$
* Author:   WYC
* Purpose:  Socket_Udp协议_服务器
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Text_013 : MonoBehaviour {

	
	void Start () {
		Socket udpSocket =new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
        udpSocket.Bind(new IPEndPoint(IPAddress.Parse("192.168.2.224"),8080 ));

        EndPoint remoteEndPoint =new IPEndPoint(IPAddress.Any, 0);
        byte[] date =new byte[1024*1024];
	    int length = udpSocket.ReceiveFrom(date, ref remoteEndPoint);
	    string message = Encoding.Default.GetString(date, 0, length);
	    Debug.Log("从Ip: " + (remoteEndPoint as IPEndPoint).Address.ToString() + " : " +
	              (remoteEndPoint as IPEndPoint).Port + "收到数据" + message);
        udpSocket.Close();
	}
	
	

}
