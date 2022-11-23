﻿using ErmerTaste.Data;
using ErmerTaste.Data.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErmerTaste.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

       
        public async Task<IActionResult> Index()
        {
            var data =  _service.GetAll();

            return View(data);
        }
    }
}
