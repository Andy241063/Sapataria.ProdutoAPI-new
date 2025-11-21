using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;

namespace Sapataria.ProdutoAPI.Application.Impl
{
    internal class DeleteProductsUseCase : IDeleteProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(string id)
        {
            _productRepository.Delete(id);
        }
    }
}
