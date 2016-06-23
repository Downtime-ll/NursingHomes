using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NursingHomes.Base.Domain;

namespace NursingHomes.Base.Store
{
    public class BaseContext : AbpDbContext
    {
        public virtual DbSet<Nurser> Nurser { get; set; }
        public virtual DbSet<OldMan> OldMan { get; set; }

        public BaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}
