using System.Collections.Generic;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Infrastructure.Impl
{
    internal class ProductRepository : IProductRepository
    {
        private List<Produto> _produtos;
       
        public ProductRepository()
        {
            _produtos = new List<Produto>();
        }

        public IEnumerable<Produto> Get()
        {
            return _produtos;
        }

        public void Save(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void Update(Produto produto, int id)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
