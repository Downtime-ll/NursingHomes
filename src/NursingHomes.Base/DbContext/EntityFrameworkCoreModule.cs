using System.Reflection;
using Abp.EntityFrameworkCore;
using Abp.Modules;

namespace NursingHomes.Base.DbContext
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
