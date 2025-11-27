using System.Collections.Generic;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application
{
    public interface IReadProductsUseCase
    {
        IEnumerable<Produto> GetProducts(string id);

        IEnumerable<Produto> GetAll();
    }
}
