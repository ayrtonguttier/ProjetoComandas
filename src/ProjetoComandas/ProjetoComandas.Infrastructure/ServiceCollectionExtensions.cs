using Microsoft.Extensions.DependencyInjection;
using ProjetoComandas.Application.Data;
using ProjetoComandas.Application.Data.Repositories;
using ProjetoComandas.Infrastructure.Repositories;

namespace ProjetoComandas.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static void AddInfraServices(this IServiceCollection services, string connectionString)
    {
        services.AddSingleton<IDbConnectionFactory, DbConnectionFactory>(x =>
            new DbConnectionFactory(connectionString));
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<ICategoriaRepository, CategoriaRepository>();
    }
}