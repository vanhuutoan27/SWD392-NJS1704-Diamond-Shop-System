using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DiamonShop.Data
{
    public class DiamondContextFactory : IDesignTimeDbContextFactory<DiamondContext>
    {
        public DiamondContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<DiamondContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DiamondConnection"));
            return new DiamondContext(builder.Options);
        }
    }
}
