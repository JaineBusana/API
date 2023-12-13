using Dapper;
using MySql.Data.MySqlClient;

namespace ParticandoAPI.Infrastructure
{
    public class Connection
    {
        protected string ConnectionString = "Server=localhost;database=pi;User=root;password=root;";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        protected async Task<int> Execute(string sql, object obj)
        {
            using (MySqlConnection con = GetConnection())
            {
                return await con.ExecuteAsync(sql, obj);
            }
        }
    }
}
