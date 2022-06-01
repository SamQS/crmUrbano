using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crmUrbano.Models;

namespace crmUrbano.Controllers
{
    public class PagoPlazosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PagoPlazosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PagoPlazos()
        {
            return View();
        }
    }
}