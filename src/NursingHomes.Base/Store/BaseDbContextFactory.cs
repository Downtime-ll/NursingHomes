using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace NursingHomes.Base.Store
{
    public class BaseDbContextFactory:IDbContextFactory<BaseContext>
    {
        public BaseContext Create()
        {
            var builder = new DbContextOptionsBuilder<BaseContext>();
            builder.UseSqlServer("Server=localhost; Database=AbpProjectNameDb; Trusted_Connection=True;");
            return new BaseContext(builder.Options);
        }
    }
}
