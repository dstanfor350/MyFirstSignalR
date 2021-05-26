using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//
// This is server side code!!
//

namespace MyFirstSignalR
{
    // The HubName attributes enable a custom hub name without using Pascal case
    // This attribute is not required.
    [HubName("myHub")]
    public class MyHub : Hub
    {
        public void Hello(string message)
        //public void Send(string message)
        {
            Clients.All.hello(message);
            //Clients.All.broadcastMessage(message);
        }
    }
}