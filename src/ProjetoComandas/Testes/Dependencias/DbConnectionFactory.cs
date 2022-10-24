using MySql.Data.MySqlClient;
using System.Data;
using ProjetoComandas.Application.Data;


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
