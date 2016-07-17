using Microsoft.AspNetCore.Hosting;
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
             CreateAspNetCoreCommunicationContext();

            //ServiceRuntime.RegisterServiceAsync("NursingHomesBaseType", serviceContext => 
            //        new WebAppService(serviceContext, communicationContext))
            //    .GetAwaiter().GetResult();

        }

        private static void CreateAspNetCoreCommunicationContext()
        {
            var webHost = new WebHostBuilder().UseKestrel()
                                              .UseIISIntegration()
                                              .UseContentRoot(Directory.GetCurrentDirectory())
                                              .UseStartup<Startup>()
                                              //.UseServiceFabricEndpoint("NursingHomesBaseTypeEndpoint")
                                              .Build();
            webHost.Run();

            //return new AspNetCoreCommunicationContext(webHost);
        }
    }
}
