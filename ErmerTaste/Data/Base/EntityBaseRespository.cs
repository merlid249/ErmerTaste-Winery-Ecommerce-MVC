using ErmerTaste.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ErmerTaste.Data.Base
{
    public class EntityBaseRespository<T>: IEntityBaseRespository<T> where T : class,IEntityBase, new()
    {
        private readonly AppDbContext _context;
        public EntityBaseRespository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public  async Task DeleteAsync(int id)
        {
             var entity= await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

       

        public async Task UpdateAsync(int id, T entity)
        {
            EntityEntry entityEntry=  _context.Entry(entity);
            entityEntry.State= EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var allactors = await _context.Set<T>().ToListAsync();

            return allactors;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var results = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            return results;
        }
    }
}
