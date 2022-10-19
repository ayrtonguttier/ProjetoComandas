using ProjetoComandas.Domain.Produtos;
using ProjetoComandas.Infrastructure.Produtos.Produto;
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
            var produto = new Produto("IPhone", "0000000", 6000, new Categoria("Smartphone"));
            var resultado = repository.Add(produto);
            Assert.True(resultado.EhSucesso());
        }
    }
}