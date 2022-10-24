using ProjetoComandas.Domain;

namespace ProjetoComandas.Application.Data
{
    public interface IRepository<T> where T : class
    {
        Result<T> Add(T item);
        Result<T> Update(T item);
        Result<T> Delete(T item);
        Result<IEnumerable<T>> GetAll();


        Task<Result<T>> AddAsync(T item);
        Task<Result<T>> UpdateAsync(T item);
        Task<Result<T>> DeleteAsync(T item);
        Task<Result<IEnumerable<T>>> GetAllAsync();
    }
}
