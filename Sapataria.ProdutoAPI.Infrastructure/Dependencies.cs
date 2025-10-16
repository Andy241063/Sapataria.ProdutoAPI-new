using Microsoft.Extensions.DependencyInjection;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Infrastructure.Impl;

namespace Sapataria.ProdutoAPI.Infrastructure
{
    public static class Dependencies
    {
        public static void AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
