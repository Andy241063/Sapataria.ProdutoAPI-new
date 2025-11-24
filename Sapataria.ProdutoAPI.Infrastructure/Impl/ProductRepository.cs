using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Sapataria.ProdutoAPI.Infrastructure.Impl
{
    internal class ProductRepository : IProductRepository
    {
        string connectionString = "Server=localhost;Port=3306;Database=sapataria;User ID=root;Password=;";
        
        private List<Produto> _produtos;
       
        public ProductRepository()
        {
            _produtos = new List<Produto>();
        }

        // Essa linha ta criando uma classe com um enumeravel de produto
        // e um metodo Get que retorna esse enumeravel, é isso ? 
        public IEnumerable<Produto> Get() 
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "select id, nome, valor, marca, modelo from produto";

            using var command = new MySqlCommand(query, connection);
            
            using var reader = command.ExecuteReader();

            List<Produto> produtoList = new List<Produto>();

            while (reader.Read())
            {
                var produto = new Produto
                {
                    id = reader.GetString("id"),
                    nome = reader.GetString("nome"),
                    valor = reader.GetDecimal("valor"),
                    marca = reader.GetString("marca"),
                    modelo = reader.GetString("modelo")
                };

                produtoList.Add(produto);
            }

            return produtoList;
        }

        public void Save(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void Update(Produto produto, string id)
        {
            _produtos.Add(produto);
        }
    }
}
