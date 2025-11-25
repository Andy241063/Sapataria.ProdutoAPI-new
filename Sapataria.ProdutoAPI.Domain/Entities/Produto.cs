namespace Sapataria.ProdutoAPI.Domain.Entities
{
    public class Produto
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
    }
}

