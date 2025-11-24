using Microsoft.Extensions.DependencyInjection;
using Sapataria.ProdutoAPI.Application.Impl;


namespace Sapataria.ProdutoAPI.Application
{
    public static class Dependencies
    {
        public static void AddApplicationDependencies(this IServiceCollection Services)
        {
            Services.AddScoped<IDeleteProductsUseCase, DeleteProductsUseCase>();
            Services.AddScoped<IReadProductsUseCase, ReadProductsUseCase>();
            Services.AddScoped<IRegisterProductsUseCase, RegisterProductsUseCase>();
        }
    }
}
