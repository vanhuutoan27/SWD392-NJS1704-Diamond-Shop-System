using DiamonShop.Data;
using Microsoft.EntityFrameworkCore;

namespace DiamonShop.API
{
    public static class MigrationManager
    {
        public static WebApplication MigrationDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<DiamondContext>())
                {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }
    }
}
