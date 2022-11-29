using ErmerTaste.Models;

namespace ErmerTaste.Data.Service
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        void AddAsync(Actor actor);  
        Actor UpdateAsync(int id,Actor actor);
        void DeleteAsync(int id);    
    }
}
