

namespace EFRepositoryMVC.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
      
        T Add(T entity);
        Task<List<T>> GetAllAsync();


    }
}
