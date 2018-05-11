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
* Filename: Text_012
* Created:  $time$
* Author:   WYC
* Purpose:  socket_Tcp协议_服务器
* ==============================================================================
*/
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class Text_012 : MonoBehaviour {

	private List<Client> clientList =new List<Client>(); 
	void Start ()
	{
	    Socket TcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        TcpServer.Bind(new IPEndPoint(IPAddress.Any, 7788));
        TcpServer.Listen(100);
        Debug.Log("开始监听");
	    while (true)
	    {
	        Socket clientSocket = TcpServer.Accept();
	        Debug.Log("客户端： " + clientSocket.RemoteEndPoint.ToString() + "  连接上来");
	        Client client = new Client(clientSocket);//把每个客户端通信逻辑放在client类里面处理
	        clientList.Add(client);
        }
	}
    ////广播形式
    //public void BroadcastMessage(string message)
    //{
    //    foreach (Client c in clientList)
    //    {
    //        c.SendMessage(message);
    //    }
    //}

}

class Client
{
    private Socket _clientSocket;
    private Thread t;
    private byte[] date = new byte[1024 * 1024];//创建一个1M数据容器

    public Client(Socket s)
    {
        _clientSocket = s;
        //启动线程 处理客户端数据接收
        t = new Thread(ReceiveMessage);
        t.Start();
    }

    public void SendMessage(string message)
    {
        byte[] date = Encoding.Default.GetBytes(message);
        _clientSocket.Send(date);
    }


    private void ReceiveMessage()
    {
        //一直接收客户端的数据
        while (true)
        {
            //在接受数据之前  判断socket是否断开
            if (_clientSocket.Poll(10,SelectMode.SelectRead))
            {
                _clientSocket.Close();
                break;//跳出死循环
            }
            int length = _clientSocket.Receive(date);
            string message = Encoding.Default.GetString(date, 0, length);
            
            Debug.Log("收到了消息："+message+_clientSocket.Connected);
        }
    }
}
