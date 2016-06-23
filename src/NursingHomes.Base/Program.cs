﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System.Collections.Generic;
using System.Fabric;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.AspNetCore.Hosting;

namespace NursingHomes.Base
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var communicationContext = CreateAspNetCoreCommunicationContext();

            ServiceRuntime.RegisterServiceAsync("NursingHomesBaseType", serviceContext => 
                    new WebAppService(serviceContext, communicationContext))
                .GetAwaiter().GetResult();

            communicationContext.WebHost.Run();
        }

        private static AspNetCoreCommunicationContext CreateAspNetCoreCommunicationContext()
        {
            var webHost = new WebHostBuilder().UseKestrel()
                                              .UseContentRoot(Directory.GetCurrentDirectory())
                                              .UseStartup<Startup>()
                                              .UseServiceFabricEndpoint("NursingHomesBaseTypeEndpoint")
                                              .Build();

            return new AspNetCoreCommunicationContext(webHost);
        }
    }
}
