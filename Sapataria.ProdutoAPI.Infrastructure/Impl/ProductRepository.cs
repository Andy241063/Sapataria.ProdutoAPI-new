using MySql.Data.MySqlClient;
using Sapataria.ProdutoAPI.Application.Infrastructure.Interfaces;
using Sapataria.ProdutoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Sapataria.ProdutoAPI.Infrastructure.Impl
{
    internal class ProductRepository : IProductRepository
    {
        public class DatabaseConnection
        {
                public static void Connect()
                {
                    string connectionString = "server=127.0.0.1;database=sua_base;uid=root;pwd=sua_senha;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {   
                        // Por que utilizar using na criacao da instancia ?
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

        private List<Produto> _produtos;
       
        public ProductRepository()
        {
            _produtos = new List<Produto>();
        }

        public IEnumerable<Produto> Get()
        {
            return _produtos;
        }

        public void Save(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void Update(Produto produto, int id)
        {
        }

        public void Delete(int id)
        {
        }
    }
}
