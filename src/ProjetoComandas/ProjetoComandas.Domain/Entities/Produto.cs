namespace ProjetoComandas.Domain.Entities
{
    public sealed class Produto
    {
        public Produto(string nome, string codigoDeBarras, decimal preco, Categoria categoria)
        {
            this.Id = null;
            this.Nome = nome;
            this.CodigoDeBarras = codigoDeBarras;
            this.Preco = preco;
            this.Categoria = categoria;
            this.DataDeCadastro = DateTimeOffset.UtcNow;
        }
        public Produto(int id, string nome, string codigoDeBarras, decimal preco, Categoria categoria, DateTimeOffset dataDeCadastro) : this(id, nome, codigoDeBarras, preco, categoria, dataDeCadastro, null) { }
        public Produto(int id, string nome, string codigoDeBarras, decimal preco, Categoria categoria, DateTimeOffset dataDeCadastro, DateTimeOffset? dataDeAlteracao)
        {
            this.Id = id;
            this.Nome = nome;
            this.CodigoDeBarras = codigoDeBarras;
            this.Preco = preco;
            this.Categoria = categoria;
            this.DataDeCadastro = dataDeCadastro;
            this.DataDeAlteracao = dataDeAlteracao;
        }

        public int? Id { get; private set; }
        public string CodigoDeBarras { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public DateTimeOffset DataDeCadastro { get; private set; }
        public DateTimeOffset? DataDeAlteracao { get; private set; }
        public Categoria Categoria { get; private set; }

    }
}
