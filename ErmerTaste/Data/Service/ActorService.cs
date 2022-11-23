using ErmerTaste.Models;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Data.Service
{
    public class ActorService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            context =_context;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var allactors= await _context.Actors.ToListAsync();

            return allactors;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor actor)
        {
            throw new NotImplementedException();
        }

    }
}
