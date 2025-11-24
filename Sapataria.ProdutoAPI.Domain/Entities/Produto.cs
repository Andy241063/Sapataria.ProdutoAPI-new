namespace Sapataria.ProdutoAPI.Domain.Entities
{
    public class Produto
    {
        public string? id;
        public string? nome;
        public decimal valor;
        public string? marca;
        public string? modelo;

        public string? Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
    }
}

