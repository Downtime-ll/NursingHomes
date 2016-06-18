using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NursingHomes.Base.Domain;

namespace NursingHomes.Base.Store
{
    public class BaseContext : DbContext
    {
        public virtual DbSet<Nurser> Nurser { get; set; }
        public virtual DbSet<OldMan> OldMan { get; set; }
    }
}
