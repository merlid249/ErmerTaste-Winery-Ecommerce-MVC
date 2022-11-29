using ErmerTaste.Models;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Data.Service
{
    public class ActorService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context;
        }
        public async void AddAsync(Actor actor)
        {
            await  _context.Actors.AddAsync(actor); 
            await _context.SaveChangesAsync();
        }

        public void DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var allactors= await _context.Actors.ToListAsync();

            return allactors;
        }

        public async Task<IEnumerable<Actor>> GetByIdAsync(int id)
        {
            var results = await  _context.Actors.FirstOrDefault(n => n.Id == id);
            return results;
        }

        public Actor UpdateAsync(int id, Actor actor)
        {
            throw new NotImplementedException();
        }

    }
}
