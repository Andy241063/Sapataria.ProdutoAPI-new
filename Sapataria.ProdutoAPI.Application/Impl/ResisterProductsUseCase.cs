using System.Collections.Generic;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application.Impl
{
    internal class ResisterProductsUseCase : IResisterProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public ResisterProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void SetProducts(Produto produto)
        {
            _productRepository.Save(produto);
        }

        public IEnumerable<Produto> SetProducts()
        {
            throw new System.NotImplementedException();
        }
    }

    }
}
