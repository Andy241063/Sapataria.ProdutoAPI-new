using System.Collections.Generic;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Infrastructure.Impl
{
    internal class ProductRepository : IProductRepository
    {
        public IEnumerable<Produto> Get()
        {
            return new List<Produto>();
        }

        public void Save(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Produto produto, int id)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
