using ProjetoComandas.Domain.Entities;
using ProjetoComandas.Infrastructure.Repositories;
using Testes.Dependencias;
using Xunit.Abstractions;

namespace Testes
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper outputHelper;

        public UnitTest1(ITestOutputHelper outputHelper)
        {
            this.outputHelper = outputHelper;
        }

        [Fact]
        public void TesteSucessoCadastrarCliente()
        {
            var repository = new ProdutoRepository(new MyTestLogger<ProdutoRepository>(outputHelper), new DbConnectionFactory());
            var produto = new Produto()
            {
                Nome = "IPhone",
                Preco = 6000,
                CodigoDeBarras = "000000000",
                DataDeCadastro = DateTimeOffset.UtcNow,
                Categoria = new Categoria()
                {
                    Nome = "SmartPhone",
                    DataDeCadastro = DateTimeOffset.UtcNow
                }
            };
            
            var resultado = repository.Add(produto);
            Assert.True(resultado.EhSucesso());
        }
    }
}