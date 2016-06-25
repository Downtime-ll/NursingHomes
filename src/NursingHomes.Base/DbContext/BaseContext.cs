using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NursingHomes.Base.Domain;

namespace NursingHomes.Base.DbContext
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
