using ProjetoComandas.Application.Data.Repositories;
using ProjetoComandas.Domain;

namespace ProjetoComandas.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Result<Domain.Entities.Categoria> Add(Domain.Entities.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Entities.Categoria>> AddAsync(Domain.Entities.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Result<Domain.Entities.Categoria> Delete(Domain.Entities.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Entities.Categoria>> DeleteAsync(Domain.Entities.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Result<IEnumerable<Domain.Entities.Categoria>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Domain.Entities.Categoria>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Result<Domain.Entities.Categoria> Update(Domain.Entities.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Entities.Categoria>> UpdateAsync(Domain.Entities.Categoria item)
        {
            throw new NotImplementedException();
        }
    }
}
