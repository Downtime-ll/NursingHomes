using System.Reflection;
using Abp.AspNetCore;
using Abp.AutoMapper;
using Abp.Modules;
using NursingHomes.Base.Store;

namespace NursingHomes.Base
{
    [DependsOn(
        typeof(AbpAutoMapperModule),
        typeof(EntityFrameworkCoreModule),
        typeof(AbpAspNetCoreModule))]
    public class AbpNursingHomesBaseModule : AbpModule
    {

        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;
        }
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
