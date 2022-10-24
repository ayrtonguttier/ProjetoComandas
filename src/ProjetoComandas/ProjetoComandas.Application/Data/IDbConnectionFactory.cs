using System.Data;

namespace ProjetoComandas.Application.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
