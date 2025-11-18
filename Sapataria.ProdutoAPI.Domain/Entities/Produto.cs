namespace Sapataria.ProdutoAPI.Domain.Entities
{
    public class Produto
    {
        public string? Produto_id;
        public string? Nomeproduto;
        public decimal Valorproduto;
        public string? Marcaproduto;
        public string? Modeloproduto;

        public string? produto_Id { get; set; }
        public string? nome { get; set; }
        public decimal valor { get; set; }
        public string? marca { get; set; }
        public string? modelo { get; set; }

    }
}
