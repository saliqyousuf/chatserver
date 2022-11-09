using System;
using System.Web;
using Microsoft.AspNetCore.SignalR;

namespace Chatserver
{
    public class ChatHub :Hub
    {

        public void SendMessage(string name,string message)
        {
            Clients.All.SendAsync("ReceiveMessage",name, message);
        }
    }
}
