using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Abp.Modules;

namespace NursingHomes.Base.Store
{
    [DependsOn(
        typeof(AbpEntityFrameworkCoreModule))]
    public class EntityFrameworkCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
