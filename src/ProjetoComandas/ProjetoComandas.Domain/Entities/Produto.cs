namespace ProjetoComandas.Domain.Entities
{
    public sealed class Produto
    {
        public int? Id { get;  set; }
        public string CodigoDeBarras { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public decimal Preco { get;  set; }
        public DateTimeOffset DataDeCadastro { get;  set; }
        public DateTimeOffset? DataDeAlteracao { get;  set; }
        public Categoria Categoria { get; set; } = new Categoria();

    }
}
