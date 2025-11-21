using System.Collections.Generic;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application.Impl
{
    internal class RegisterProductsUseCase : IRegisterProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public RegisterProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Save(Produto produto)
        {
            _productRepository.Save(produto);
        }

        public void Update(Produto produto, string id)
        {
            _productRepository.Update(produto, id);
        }
    }
}
