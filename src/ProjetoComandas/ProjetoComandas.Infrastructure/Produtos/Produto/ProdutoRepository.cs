using Dapper;
using Microsoft.Extensions.Logging;
using ProjetoComandas.Domain;
using ProjetoComandas.Domain.Produtos.Repositories;

namespace ProjetoComandas.Infrastructure.Produtos.Produto
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
        public Result<Domain.Produtos.Produto> Add(Domain.Produtos.Produto item)
        {
            return this.AddAsync(item).GetAwaiter().GetResult();
        }

        public async Task<Result<Domain.Produtos.Produto>> AddAsync(Domain.Produtos.Produto item)
        {
            try
            {
                using (var connection = connectionFactory.CreateConnection())
                {
                    var sql = "INSERT INTO TB_PRODUTO (ID, NOME, CODIGO_BARRAS, PRECO, ID_CATEGORIA, DATA_CADASTRO) VALUES (@ID, @NOME, @CODIGO_BARRAS, @PRECO, @ID_CATEGORIA, @DATA_CADASTRO)";
                    await connection.ExecuteAsync(sql, new
                    {
                        @ID = item.Id,
                        @NOME = item.Nome,
                        @CODIGO_BARRAS = item.CodigoDeBarras,
                        @PRECO = item.Preco,
                        @ID_CATEGORIA = item.Categoria.Id,
                        @DATA_CADASTRO = item.DataDeCadastro
                    });

                    return new Result<Domain.Produtos.Produto>(item);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Erro ao cadastrar produto");
                return new Result<Domain.Produtos.Produto>(ex);
            }
        }

        public Result<Domain.Produtos.Produto> Delete(Domain.Produtos.Produto item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Produtos.Produto>> DeleteAsync(Domain.Produtos.Produto item)
        {
            throw new NotImplementedException();
        }

        public Result<IEnumerable<Domain.Produtos.Produto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Domain.Produtos.Produto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Result<Domain.Produtos.Produto> Update(Domain.Produtos.Produto item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Produtos.Produto>> UpdateAsync(Domain.Produtos.Produto item)
        {
            throw new NotImplementedException();
        }
    }
}
