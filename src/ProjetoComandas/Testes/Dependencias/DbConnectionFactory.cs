using MySql.Data.MySqlClient;
using ProjetoComandas.Infrastructure;
using System.Data;

namespace Testes.Dependencias
{
    internal class DbConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection("Server=localhost;Database=usuario;Uid=root;Pwd=senhaFortissima;");
        }
    }
}
