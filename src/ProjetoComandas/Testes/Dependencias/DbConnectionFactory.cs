using MySql.Data.MySqlClient;
using ProjetoComandas.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Dependencias
{
    internal class DbConnectionFactory : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
        {
            return new MySqlConnection("Server=localhost;Database=db_comandas;Uid=root;Pwd=root;");
        }
    }
}
