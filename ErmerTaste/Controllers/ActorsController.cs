using ErmerTaste.Data;
using Microsoft.AspNetCore.Mvc;

namespace ErmerTaste.Controllers
{
    public class ActorsController : Controller
    {
        private readonly  AppDbContext  _contect;

        public ActorsController(AppDbContext contect)
        {
            _contect = contect;
        }

        public IActionResult Index()
        {
            var data = _contect.Actors.ToList();
            return View();
        }
    }
}
