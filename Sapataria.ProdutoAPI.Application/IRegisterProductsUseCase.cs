using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application
{
    public interface IRegisterProductsUseCase
    {
        void Save(Produto produto);
        void Update(Produto produto, int id);
    }
}
