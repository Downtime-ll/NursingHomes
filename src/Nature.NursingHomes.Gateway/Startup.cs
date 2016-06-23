using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.ServiceFabric.AspNetCore.Gateway;
using Microsoft.ServiceFabric.Services.Communication.Client;

namespace Nature.NursingHomes.Gateway
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                      .AddEnvironmentVariables()
                                                      .Build();
        }
        public IConfigurationRoot Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDefaultHttpRequestDispatcherProvider();
        }

        public void Configure(IApplicationBuilder app)
        {
            //base
            var smsOptions = new GatewayOptions()
            {
                ServiceUri = new Uri("fabric:/NursingHomes.App/Base", UriKind.Absolute),

                OperationRetrySettings = new OperationRetrySettings(TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(2), 30),
            };
            app.Map("/base",
               subApp =>
               {
                   subApp.RunGateway(smsOptions);
               }
           );
        }
    }
}
