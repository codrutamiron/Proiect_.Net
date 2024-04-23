using Store.Core.Services;
using Store.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Store.Core.Extensions
{
    public static class ServicesExtension
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
        }

    }
}
