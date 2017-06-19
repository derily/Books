using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace PerfSurf.Hubs
{
    public class PerfHub : Hub
    {
        public void Send(string name,string message)
        {
            //Clients.All.newMessage(
            //        Context.User.Identity.Name+" says "+message
            //    );
            Clients.All.broadcastMessage(name, message);
        }

        public void SendNotifications(string message)
        {
            Clients.All.receiveNotification(message);
        }
    }
}