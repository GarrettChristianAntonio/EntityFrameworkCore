using System.Linq.Expressions;

namespace CodeFirstPatronRepositorio.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        T Add(T entity);
        T Update(T entity);
        Task DeleteByIdAsync(int id);
        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);
    }
}
