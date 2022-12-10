using ErmerTaste.Models;

namespace ErmerTaste.Data.Base
{
    public interface IEntityBaseRespository<T> where T : class,IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task DeleteAsync(int id);

    }
}
