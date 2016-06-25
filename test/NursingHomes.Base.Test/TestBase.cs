using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Collections;
using Abp.Modules;
using Abp.TestBase;
using NursingHomes.Base.DbContext;

namespace NursingHomes.Base.Test
{
    /// <summary>
    /// 测试抽象基类
    /// </summary>
    public abstract class TestBase : AbpIntegratedTestBase
    {
        protected override void AddModules(ITypeList<AbpModule> modules)
        {
            base.AddModules(modules);
            modules.Add<TestModule>();
        }

        protected virtual void UsingDbContext(Action<BaseContext> action)
        {
            using (var context = LocalIocManager.Resolve<BaseContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BaseContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BaseContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BaseContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BaseContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BaseContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BaseContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
