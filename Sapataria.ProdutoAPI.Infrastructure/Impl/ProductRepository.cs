using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Sapataria.ProdutoAPI.Infrastructure.Impl
{
    internal class ProductRepository : IProductRepository
    {
        string connectionString = "server=MyLocalHost;database=sapataria;uid=root";
        
        private List<Produto> _produtos;
       
        public ProductRepository()

        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

            try
            {
                connection.Open();
                Console.WriteLine("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
            }

            _produtos = new List<Produto>();
        }

        public IEnumerable<Produto> Get()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar: " + ex.Message);
                }

            return _produtos;
        }

        public void Save(Produto produto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar: " + ex.Message);
                }

            _produtos.Add(produto);
        }

        public void Update(Produto produto, int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

            try
            {
                connection.Open();
                Console.WriteLine("Conexão bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar: " + ex.Message);
                }
        }
    }
}
