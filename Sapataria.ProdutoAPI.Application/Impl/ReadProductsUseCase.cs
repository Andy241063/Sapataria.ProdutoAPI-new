using System.Collections.Generic;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application.Impl
{
    internal class ReadProductsUseCase : IReadProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public ReadProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Produto> GetProducts()
        {
            _productRepository.Save(new Produto { Name = "prod1" });
            _productRepository.Save(new Produto { Name = "prod2" });

            return _productRepository.Get();
        }
    }
}
