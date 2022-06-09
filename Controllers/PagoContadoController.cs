using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using crmUrbano.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using crmUrbano.Models;

namespace crmUrbano.Controllers
{
    public class PagoContadoController : Controller
    {
            private readonly ILogger<HomeController> _logger;
     private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

        public PagoContadoController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
               _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> PagoContado()
        {
        
           var userID = _userManager.GetUserName(User);
        var items = from o in _context.Carrito select o;
            items = items.Include(c => c.Catalogo).
            Where(s => s.Usuario.Equals(userID));            
            return View(await items.ToListAsync());
           
        }
         public IActionResult ConfirmacionPagoContado()
        {
            return View();
        }
    }
}