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

        public IEnumerable<Produto> Get() // Essa linha ta criando uma classe com um enumeravel de produto
                                          // e um metodo Get que retorna esse enumeravel, é isso ? 
        {
            using var connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "select product_id, nome, valor, marca, modelo from produto";

            using var command = new MySqlCommand(query, connection);
            
            using var reader = command.ExecuteReader();

            List<Produto> produtoList = new List<Produto>();

            while (reader.Read())
            {
                var produto = new Produto {Product_Id = reader.GetString("produto_id"),
                                           Name = reader.GetString("nome"),
                                           Value = reader.GetInt32("valor"),
                                           Brand = reader.GetString("marca"),
                                           Model = reader.GetString("modelo")};

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
