using ErmerTaste.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _contect;
        public MoviesController(AppDbContext contect)
        {
            _contect = contect;
        }
        public async Task<IActionResult> Index()
        
        {
            var allMovies = await _contect.Movies.Include(n=>n.Cinema).OrderBy(n=>n.Name).ToListAsync();

            return View(allMovies);
        }
    }
}
