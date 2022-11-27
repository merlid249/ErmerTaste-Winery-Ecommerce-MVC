using ErmerTaste.Models;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Data.Service
{
    public class CinemaService : ICinemaService
    {
        private readonly AppDbContext _context;

        public CinemaService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Cinema actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cinema>> GetAll()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();

            return allCinemas;
        }

        public Cinema GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cinema Update(int id, Cinema actor)
        {
            throw new NotImplementedException();
        }
    }
}
