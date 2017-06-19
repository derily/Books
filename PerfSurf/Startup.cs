using Microsoft.Owin.Cors;
using Microsoft.AspNet.SignalR;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using PerfSurf;

[assembly: OwinStartup(typeof(Startup))]
namespace PerfSurf
{
    
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);
                var hubConfiguration = new HubConfiguration
                {

                };
                map.RunSignalR(hubConfiguration);
            });
           // app.MapSignalR();
        }
    }
}