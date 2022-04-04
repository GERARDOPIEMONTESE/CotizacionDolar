using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CotizacionDolar.Models;
using CotizacionDolarLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CotizacionDolar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration )
        {
            _logger = logger;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var url = _configuration.GetValue<string>("UrlCotizacion");
            var coti = CotizacionDolarAPI.ObtenerCotizacionDolar(url);
            var cotiModel = new CotizacionDolarModel(coti);

            return View(cotiModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
