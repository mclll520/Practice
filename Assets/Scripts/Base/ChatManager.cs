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
* Filename: ChatManager
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

public class ChatManager : MonoBehaviour
{
    private Socket clientSocket;
    public string IP = "192.168.2.224";
    public int Port = 8080;
    public UIInput TextInput;

    void Start ()
    {
        ConnectToServer();

    }
	


    void ConnectToServer()
    {
        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //跟服务器端建立连接
        clientSocket.Connect(new IPEndPoint(IPAddress.Parse(IP),Port ));
    }

    void SendMessages(string message)
    {
        clientSocket.Send(Encoding.Default.GetBytes(message));
    }

    public void OnSendButtonClick()
    {
        string value = TextInput.value;
        SendMessages(value);
        TextInput.value = null;
    }

    void OnDestroy()
    {
        clientSocket.Shutdown(SocketShutdown.Both);
        clientSocket.Close();//关闭连接
    }
}
