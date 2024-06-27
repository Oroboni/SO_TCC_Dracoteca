using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TCC_Dracoteca.Models
{
    public class Dados
    {
        private readonly string connectionString;

        public Dados()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SomeeDbConnection"].ConnectionString;
        }

        public void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                }
            }
        }

        public void ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Consulta executada com sucesso!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao executar a consulta: {ex.Message}");
                }
            }
        }
    }
}