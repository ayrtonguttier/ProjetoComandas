namespace ProjetoComandas.Domain.Entities
{
    public sealed class Categoria
    {
        public int? Id { get;  set; }
        public string Nome { get; set; } = string.Empty;
        public IEnumerable<Produto> Produtos { get; set; } = Enumerable.Empty<Produto>();
        public DateTimeOffset DataDeCadastro { get;  set; }
        public DateTimeOffset? DataDeAlteracao { get;  set; }
    }
}
