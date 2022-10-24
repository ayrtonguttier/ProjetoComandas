using System.Data;
using MySql.Data.MySqlClient;
using ProjetoComandas.Application.Data;

namespace ProjetoComandas.Infrastructure;

internal class DbConnectionFactory: IDbConnectionFactory
{
    private readonly string _connectionString;

    public DbConnectionFactory(string connectionString)
    {
        _connectionString = connectionString;
    }
    
    public IDbConnection CreateConnection()
    {
        return new MySqlConnection(_connectionString);
    }
}