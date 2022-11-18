using ErmerTaste.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ErmerTaste.Data
{
    public class AppDbContext : DbContext
    { 
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options ) 
        { 
        }
        protected  override  void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.Movie.Id,
                am.ActorId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(am =>
            am.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actor_Movies).HasForeignKey(am =>
            am.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
