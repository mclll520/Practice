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
* Filename: Text_014
* Created:  $time$
* Author:   WYC
* Purpose:   Socket_Udp协议_客户端
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Text_014 : MonoBehaviour {

	
	void Start () {
		//创建socket
        Socket udpSocket =new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);


        EndPoint serverPoint =new IPEndPoint(IPAddress.Parse("192.168.2.224"),8080 );
	    string message = "我真帅啊";
	    byte[] date = Encoding.Default.GetBytes(message);

	    udpSocket.SendTo(date,serverPoint);
	}
	
	
	void Update () {
		
	}
}
