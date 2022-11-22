using ErmerTaste.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Controllers
{
    public class ActorsController : Controller
    {
        private readonly  AppDbContext  _contect;

        public ActorsController(AppDbContext contect)
        {
            _contect = contect;
        }

       
        public async Task<IActionResult> Index()
        {
            
            var data = await _contect.Actors.ToListAsync();

            return View(data);
        }
    }
}
