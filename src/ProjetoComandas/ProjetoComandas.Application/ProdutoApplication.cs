using ProjetoComandas.Application.Data.Repositories;
using ProjetoComandas.Domain;
using ProjetoComandas.Domain.Entities;

namespace ProjetoComandas.Application;

public class ProdutoApplication
{
    private readonly IProdutoRepository _repository;

    public ProdutoApplication(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public Task<Result<IEnumerable<Produto>>> ConsultarProdutos() => _repository.GetAllAsync();
}