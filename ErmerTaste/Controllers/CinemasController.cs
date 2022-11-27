using ErmerTaste.Data;
using ErmerTaste.Data.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service;
        private readonly AppDbContext _contect;
        public CinemasController(AppDbContext contect)
        {
            _contect = contect;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.GetAll();

            return View(allCinemas);
        }

    }
}
