using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.AspNetCore.Hosting;
using Microsoft.ServiceFabric.Services.Communication.Runtime;
using Microsoft.ServiceFabric.Services.Runtime;

namespace Nature.NursingHomes.Gateway
{
    public class GatewayService : StatelessService
    {
        private readonly AspNetCoreCommunicationContext _communicationContext;

        public GatewayService(StatelessServiceContext serviceContext, AspNetCoreCommunicationContext communicationContext)
            : base(serviceContext)
        {
            _communicationContext = communicationContext;
        }

        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new[] { new ServiceInstanceListener(_ => _communicationContext.CreateCommunicationListener(this)) };
        }
    }
}
