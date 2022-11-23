using ErmerTaste.Models;

namespace ErmerTaste.Data.Service
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);  
        Actor Update(int id,Actor actor);
        void Delete(int id);    
    }
}
