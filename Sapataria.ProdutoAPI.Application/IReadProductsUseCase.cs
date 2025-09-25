using System.Collections.Generic;

namespace Sapataria.ProdutoAPI.Application
{
    public interface IReadProductsUseCase
    {
        IEnumerable<object> GetProducts();
    }
}
