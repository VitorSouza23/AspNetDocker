using System.Linq;
using AspNetDocker.InfraData;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace AspNetDocker.Extensions
{
    public static class DbExtensions
    {
        public static void DoMigrations(this IApplicationBuilder app, DataContext dataContext)
        {
            var pendingMigrations = dataContext.Database.GetPendingMigrations();
            if (pendingMigrations.Any())
            {
                dataContext.Database.Migrate();
            }
        }
    }
}