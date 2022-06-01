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
    public class PagoContadoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PagoContadoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PagoContado()
        {
        
        return View();
        }
    }
}