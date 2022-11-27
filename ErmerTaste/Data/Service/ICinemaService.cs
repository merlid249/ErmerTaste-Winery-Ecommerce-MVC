using ErmerTaste.Models;

namespace ErmerTaste.Data.Service
{
    public interface ICinemaService
    {
        Task<IEnumerable<Cinema>> GetAll();
        Cinema GetById(int id);
        void Add(Cinema actor);
        Cinema Update(int id, Cinema actor);
        void Delete(int id);
    }
}
