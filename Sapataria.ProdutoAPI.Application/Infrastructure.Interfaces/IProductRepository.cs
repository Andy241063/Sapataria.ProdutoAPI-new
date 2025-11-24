using System.Collections.Generic;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Produto> Get();
        void Save(Produto produto);
        void Update(Produto produto, string id);
        void Delete(string id);
    }
}
