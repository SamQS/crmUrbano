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
    public class ReportesController : Controller
    {
        private readonly ILogger<HomeController> _logger;
     private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

public ReportesController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Reportes()
        {
            
        var userID = _userManager.GetUserName(User);
        var applicationDbContext = _context.Carrito.Include(c => c.Catalogo);
        return View(await applicationDbContext.ToListAsync());

    }
}
}
