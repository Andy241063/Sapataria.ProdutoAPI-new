using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

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
        public Produto Get(string id)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = @"select id, nome, valor, marca,
                           modelo from produto where id = @id";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            var produto = new Produto
            {
                Id = reader.GetString("id"),
                Nome = reader.GetString("nome"),
                Valor = reader.GetDecimal("valor"),
                Marca = reader.GetString("marca"),
                Modelo = reader.GetString("modelo")
            };

            return produto;
        }

        public IEnumerable<Produto> GetAll()
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = @"select id, nome, valor, marca,
                           modelo from produto";

            using var command = new MySqlCommand(query, connection);

            //command.Parameters.AddWithValue("@id", id);

            using var reader = command.ExecuteReader();

            List<Produto> produtoList = new List<Produto>();

            while (reader.Read())
            {
                var produto = new Produto
                {
                    Id = reader.GetString("id"),
                    Nome = reader.GetString("nome"),
                    Valor = reader.GetDecimal("valor"),
                    Marca = reader.GetString("marca"),
                    Modelo = reader.GetString("modelo")
                };

                produtoList.Add(produto);
            }

            return produtoList;
        }

        public void Save(Produto produto)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = @"INSERT INTO produto (id, nome, valor, marca, modelo)
                     VALUES (@id, @nome, @valor, @marca, @modelo)";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", produto.Id);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@marca", produto.Marca);
            command.Parameters.AddWithValue("@modelo", produto.Modelo);

            command.ExecuteNonQuery();
        }

        public void Update(Produto produto, string id)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = @"UPDATE produto 
                     SET nome = @nome, 
                         valor = @valor, 
                         marca = @marca, 
                         modelo = @modelo
                     WHERE id = @id";

            using var command = new MySqlCommand(query, connection);

            // parâmetro da cláusula WHERE (o id antigo)
            command.Parameters.AddWithValue("@id", id);

            // novos valores
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@marca", produto.Marca);
            command.Parameters.AddWithValue("@modelo", produto.Modelo);

            command.ExecuteNonQuery();
        }


        public void Delete(string id)
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "DELETE FROM produto WHERE id = @id";

            using var command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }
    }
}
