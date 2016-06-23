using Microsoft.AspNetCore.Hosting;
using Microsoft.ServiceFabric.AspNetCore.Hosting;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;
using System.Collections.Generic;
using System.Fabric;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Nature.NursingHomes.Gateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var communicationContext = CreateAspNetCoreCommunicationContext();

            ServiceRuntime.RegisterServiceAsync("GatewayType", serviceContext => new GatewayService(serviceContext, communicationContext)).GetAwaiter().GetResult();

            communicationContext.WebHost.Run();
        }

        /// <summary>
        ///用于承载 ASP.NET Core Web 应用的专用无状态服务。
        /// </summary>
        private static AspNetCoreCommunicationContext CreateAspNetCoreCommunicationContext()
        {
            var webHost = new WebHostBuilder().UseKestrel()
                                              .UseContentRoot(Directory.GetCurrentDirectory())
                                              .UseStartup<Startup>()
                                              .UseServiceFabricEndpoint("GatewayTypeEndpoint")
                                              .Build();

            return new AspNetCoreCommunicationContext(webHost);
        }
    }
}
