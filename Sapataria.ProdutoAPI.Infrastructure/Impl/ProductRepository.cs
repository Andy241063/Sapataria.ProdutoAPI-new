using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;
using System;
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

        public IEnumerable<Produto> Get()
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "select name from produto";

            using var command = new MySqlCommand(query, connection);
            
            using var reader = command.ExecuteReader();

            List<Produto> produtoList = new List<Produto>();

            while (reader.Read())
            {
                var produto = new Produto { Name = reader.GetString("name") };

                produtoList.Add(produto);
            }

            return produtoList;
        }

        public void Save(Produto produto)
        {
            //using MySqlConnection connection = new MySqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    Console.WriteLine("Conexão bem-sucedida!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao conectar: " + ex.Message);
            //}

            _produtos.Add(produto);
        }

        public void Update(Produto produto, int id)
        {
            //using MySqlConnection connection = new MySqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    Console.WriteLine("Conexão bem-sucedida!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao conectar: " + ex.Message);
            //}
        }

        public void Delete(int id)
        {
            //using MySqlConnection connection = new MySqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    Console.WriteLine("Conexão bem-sucedida!");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Erro ao conectar: " + ex.Message);
            //}
        }
    }
}
