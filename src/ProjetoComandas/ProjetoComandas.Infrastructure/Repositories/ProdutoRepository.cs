using Dapper;
using Microsoft.Extensions.Logging;
using ProjetoComandas.Application.Data;
using ProjetoComandas.Application.Data.Repositories;
using ProjetoComandas.Domain;

namespace ProjetoComandas.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ILogger<ProdutoRepository> logger;
        private readonly IDbConnectionFactory connectionFactory;

        public ProdutoRepository(ILogger<ProdutoRepository> _logger, IDbConnectionFactory connectionFactory)
        {
            logger = _logger;
            this.connectionFactory = connectionFactory;
        }

        public Result<Domain.Entities.Produto> Add(Domain.Entities.Produto item)
        {
            return AddAsync(item).GetAwaiter().GetResult();
        }

        public async Task<Result<Domain.Entities.Produto>> AddAsync(Domain.Entities.Produto item)
        {
            try
            {
                using (var connection = connectionFactory.CreateConnection())
                {
                    var sql =
                        "INSERT INTO TB_PRODUTO (ID, NOME, CODIGO_BARRAS, PRECO, ID_CATEGORIA, DATA_CADASTRO) VALUES (@ID, @NOME, @CODIGO_BARRAS, @PRECO, @ID_CATEGORIA, @DATA_CADASTRO)";
                    await connection.ExecuteAsync(sql, new
                    {
                        @ID = item.Id,
                        @NOME = item.Nome,
                        @CODIGO_BARRAS = item.CodigoDeBarras,
                        @PRECO = item.Preco,
                        @ID_CATEGORIA = item.Categoria.Id,
                        @DATA_CADASTRO = item.DataDeCadastro
                    });

                    return new Result<Domain.Entities.Produto>(item);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Erro ao cadastrar produto");
                return new Result<Domain.Entities.Produto>(ex);
            }
        }

        public Result<Domain.Entities.Produto> Delete(Domain.Entities.Produto item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Entities.Produto>> DeleteAsync(Domain.Entities.Produto item)
        {
            throw new NotImplementedException();
        }

        public Result<IEnumerable<Domain.Entities.Produto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Domain.Entities.Produto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Result<Domain.Entities.Produto> Update(Domain.Entities.Produto item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Entities.Produto>> UpdateAsync(Domain.Entities.Produto item)
        {
            throw new NotImplementedException();
        }
    }
}