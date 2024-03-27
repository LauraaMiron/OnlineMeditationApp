using Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using ServicesIntrface;


namespace Servicess
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBlogPostEntityServiceInterfaces, BlogPostService>();
            services.AddScoped<IBlogPostEntityRepository, BlogPostRepository>();

        }
    }
}
