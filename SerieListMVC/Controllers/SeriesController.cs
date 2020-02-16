using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SerieList.Infrastructure.Data;
using SerieListMVC.Models;
using SeriesList.Core.Entities;
using SeriesList.Core.Interfaces;

namespace SerieListMVC.Controllers
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