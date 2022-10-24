using Dapper;
using Microsoft.Extensions.Logging;
using ProjetoComandas.Application.Data;
using ProjetoComandas.Application.Data.Repositories;
using ProjetoComandas.Domain;
using ProjetoComandas.Domain.Entities;

namespace ProjetoComandas.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ILogger<ProdutoRepository> _logger;
        private readonly IDbConnectionFactory _connectionFactory;

        public ProdutoRepository(ILogger<ProdutoRepository> logger, IDbConnectionFactory connectionFactory)
        {
            this._logger = logger;
            _connectionFactory = connectionFactory;
        }

        public Result<Produto> Add(Produto item)
        {
            return AddAsync(item).GetAwaiter().GetResult();
        }

        public async Task<Result<Produto>> AddAsync(Produto item)
        {
            try
            {
                using var connection = _connectionFactory.CreateConnection();
                var sql =
                    "INSERT INTO TB_PRODUTO (ID, NOME, CODIGO_BARRAS, PRECO, ID_CATEGORIA, DATA_CADASTRO) VALUES (@ID, @NOME, @CODIGO_BARRAS, @PRECO, @ID_CATEGORIA, @DATA_CADASTRO)";
                await connection.ExecuteAsync(sql, new
                {
                    ID = item.Id,
                    NOME = item.Nome,
                    CODIGO_BARRAS = item.CodigoDeBarras,
                    PRECO = item.Preco,
                    ID_CATEGORIA = item.Categoria.Id,
                    DATA_CADASTRO = item.DataDeCadastro
                });

                return new Result<Produto>(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao cadastrar produto");
                return new Result<Produto>(ex);
            }
        }

        public Result<Produto> Delete(Produto item)
        {
            return DeleteAsync(item).GetAwaiter().GetResult();
        }

        public async Task<Result<Produto>> DeleteAsync(Produto item)
        {
            try
            {
                using var connection = _connectionFactory.CreateConnection();
                var sql = "DELETE FROM TB_PRODUTO WHERE ID = @ID";
                await connection.ExecuteAsync(sql, new { ID = item.Id });
                return new Result<Produto>(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao deletar produto");
                return new Result<Produto>(ex);
            }
        }

        public Result<IEnumerable<Produto>> GetAll()
        {
            return GetAllAsync().GetAwaiter().GetResult();
        }

        public async Task<Result<IEnumerable<Produto>>> GetAllAsync()
        {
            try
            {
                using var connection = _connectionFactory.CreateConnection();
                var sql = "SELECT * FROM TB_PRODUTO";
                var produtos = await connection.QueryAsync<Produto>(sql);
                return new Result<IEnumerable<Produto>>(produtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao consultar produto");
                return new Result<IEnumerable<Produto>>(ex);
            }
        }

        public Result<Produto> Update(Produto item)
        {
            return UpdateAsync(item).GetAwaiter().GetResult();
        }

        public async Task<Result<Produto>> UpdateAsync(Produto item)
        {
            try
            {
                using var connection = _connectionFactory.CreateConnection();
                var sql =
                    "UPDATE TB_PRODUTO SET NOME=@NOME, CODIGO_BARRAS=@CODIGO_BARRAS, PRECO=@PRECO, ID_CATEGORIA=@ID_CATEGORIA, DATA_ALTERACAO=@DATA_ALTERACAO WHERE ID=@ID";
                await connection.ExecuteAsync(sql,
                    new
                    {
                        @NOME = item.Nome, @CODIGO_BARRAS = item.CodigoDeBarras, @PRECO = item.Preco,
                        @ID_CATEGORIA = item.Categoria.Id, @DATA_ALTERACAO = DateTimeOffset.UtcNow
                    });
                return new Result<Produto>(item);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao atualizar produto {Id}", item.Id);
                throw;
            }
        }
    }
}