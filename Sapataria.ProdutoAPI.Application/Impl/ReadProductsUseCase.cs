using System;
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
            _productRepository.Get();

            return _productRepository.Get();
        }
    }
}
