using ErmerTaste.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Controllers
{
    public class MoviesControllers : Controller
    {
        private readonly AppDbContext _contect;
        public MoviesControllers(AppDbContext contect)
        {
            _contect = contect;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _contect.Movies.ToListAsync();

            return View();
        }
    }
}
