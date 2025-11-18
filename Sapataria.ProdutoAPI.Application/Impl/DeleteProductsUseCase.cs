using Org.BouncyCastle.Asn1;
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

        public void Delete(BerOctetStringGenerator Protuto_id)
        {
            _productRepository.Delete(Protuto_id);
        }
    }
}
