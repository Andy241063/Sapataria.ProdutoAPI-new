using System.Collections.Generic;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;
using ZstdSharp.Unsafe;

namespace Sapataria.ProdutoAPI.Application.Impl
{
    internal class ReadProductsUseCase : IReadProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public ReadProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Produto> GetProducts(string id)
        {
            return _productRepository.Get(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _productRepository.GetAll();
        }
    }
}
