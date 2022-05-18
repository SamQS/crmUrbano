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
    
    public class InmueblesController: Controller
    {
    private readonly ILogger<HomeController> _logger;
     private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

public InmueblesController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Inmuebles()
         {
            var catalogos = from o in _context.Catalogo select o;
            catalogos = catalogos.Where(s => s.Status.Equals("D"));
            return View(await catalogos.ToListAsync());
        }
    }
}