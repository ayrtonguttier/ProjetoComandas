using ProjetoComandas.Domain;
using ProjetoComandas.Domain.Produtos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoComandas.Infrastructure.Produtos.Categoria
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public Result<Domain.Produtos.Categoria> Add(Domain.Produtos.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Produtos.Categoria>> AddAsync(Domain.Produtos.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Result<Domain.Produtos.Categoria> Delete(Domain.Produtos.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Produtos.Categoria>> DeleteAsync(Domain.Produtos.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Result<IEnumerable<Domain.Produtos.Categoria>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Domain.Produtos.Categoria>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Result<Domain.Produtos.Categoria> Update(Domain.Produtos.Categoria item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Domain.Produtos.Categoria>> UpdateAsync(Domain.Produtos.Categoria item)
        {
            throw new NotImplementedException();
        }
    }
}
