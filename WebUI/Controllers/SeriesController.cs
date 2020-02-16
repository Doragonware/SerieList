using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using WebUI.Models;
using Core.Entities;
using Core.Interfaces;

namespace WebUI.Controllers
{
    [Authorize]
    public class SeriesController : Controller
    {
        private readonly ISerieService _serieService;

        public SeriesController(ISerieService serieService)
        {
            _serieService = serieService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Serie> model = await _serieService.GetAll();
            return View(model);
        }
    }
}