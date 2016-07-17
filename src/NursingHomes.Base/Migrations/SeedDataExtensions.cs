using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NursingHomes.Base.DbContext;

namespace NursingHomes.Base.Migrations
{
    public static class SeedDataExtensions
    {
        public static async void SendData(this IServiceProvider serviceProvider)
        {
            using (var service = serviceProvider.GetService<IServiceScopeFactory>().CreateScope())
            {

                using (var db = service.ServiceProvider.GetRequiredService<BaseContext>())
                {
                    if (!db.Database.EnsureCreated())
                    {
                    }
                }
            }
        }
    }
}
