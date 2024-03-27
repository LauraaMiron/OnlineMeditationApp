using Data.Postgres.Repositories;
using Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Postgres.Configuration
{

    public static class DependencyInjection
    {
        public static void AddDbContext(this IServiceCollection services, string? connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));
        }

        public static void RunMigrations(this IServiceProvider services)
        {
            using var scope = services.CreateScope();
            var scopeProvider = scope.ServiceProvider;

            var context = scopeProvider.GetRequiredService<ApplicationDbContext>();
            // var appliedMigrations = context.Database.GetAppliedMigrations().ToList();
            // var allMigrations = context.Database.GetMigrations().ToList();
            // var pendingMigrations = context.Database.GetPendingMigrations().ToList();
            context.Database.Migrate();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBlogPostEntityRepository, BlogPostRepo>();
            
        }
    }
}
