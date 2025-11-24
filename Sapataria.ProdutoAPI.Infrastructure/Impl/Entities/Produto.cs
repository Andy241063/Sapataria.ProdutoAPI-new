namespace Sapataria.ProdutoAPI.Domain.Entities
{
    public class Produto
    {
        internal string? id;
        internal string? nome;
        internal decimal valor;
        internal string? marca;
        internal string? modelo;

        public string? Id { get; set; }
        public string? Nome { get; set; }
        public decimal Valor { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

    }
}
