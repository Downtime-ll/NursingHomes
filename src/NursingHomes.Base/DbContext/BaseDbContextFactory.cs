using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace NursingHomes.Base.DbContext
{
    public class BaseDbContextFactory : IDbContextFactory<BaseContext>
    {
        private readonly IConfigurationRoot _configuration;

        public BaseDbContextFactory()
        {
             var builder = new ConfigurationBuilder()
                .AddJsonFile("config\\appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            _configuration = builder.Build(); ;
        }

        public BaseContext Create()
        {
            var builder = new DbContextOptionsBuilder<BaseContext>();
            builder.UseSqlServer(_configuration.GetConnectionString("Default"));
            return new BaseContext(builder.Options);
        }
    }
}
