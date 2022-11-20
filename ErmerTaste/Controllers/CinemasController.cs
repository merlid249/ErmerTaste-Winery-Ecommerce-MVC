using ErmerTaste.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Controllers
{
    public class CinemasController : Controller
    {

        private readonly AppDbContext _contect;
        public CinemasController(AppDbContext contect)
        {
            _contect = contect;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _contect.Cinemas.ToListAsync();

            return View();
        }

    }
}
