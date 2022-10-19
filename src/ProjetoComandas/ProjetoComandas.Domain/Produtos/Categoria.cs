using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComandas.Domain.Produtos
{
    public sealed class Categoria
    {


        public Categoria(string nome)
        {
            this.Id = 10;
            this.Nome = nome;
            this.Produtos = Enumerable.Empty<Produto>();
            this.DataDeCadastro = DateTimeOffset.UtcNow;
            this.DataDeAlteracao = null;
        }

        public Categoria(int id, string nome, IEnumerable<Produto> produtos, DateTimeOffset dataDeCadastro) : this(id, nome, produtos, dataDeCadastro, null)
        {
        }

        public Categoria(int id, string nome, IEnumerable<Produto> produtos, DateTimeOffset dataDeCadastro, DateTimeOffset? dataDeAlteracao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Produtos = produtos;
            this.DataDeCadastro = dataDeCadastro;
            this.DataDeAlteracao = dataDeAlteracao;
        }

        public int? Id { get; private set; }
        public string Nome { get; private set; }
        public IEnumerable<Produto> Produtos { get; private set; }
        public DateTimeOffset DataDeCadastro { get; private set; }
        public DateTimeOffset? DataDeAlteracao { get; private set; }
    }
}
