using ErmerTaste.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ErmerTaste.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _contect;
        public ProducersController(AppDbContext contect)
        {
            _contect = contect;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _contect.Producers.ToListAsync();

            return View(allProducers);
        }
    }
}
