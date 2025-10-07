using System.Collections.Generic;
using Sapataria.ProdutoAPI.Domain.Entities;

namespace Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces
{
    public interface IResisterProductsUseCase
    {
        IEnumerable<Produto> SetProducts();
    }
}
