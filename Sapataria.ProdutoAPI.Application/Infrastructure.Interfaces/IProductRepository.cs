using System;
using System.Collections.Generic;
using System.Text;
using Sapataria.ProdutoAPI.Domain.Entities;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Produto> Get();
        void Save(Produto produto);
        void Update(Produto produto, int id);
        void Delete(int id);
    }
}
