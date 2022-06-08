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
        public async Task<IActionResult> Inmuebles(string? searchString)
         {
        var catalogos = from o in _context.Catalogo select o;
        if(!String.IsNullOrEmpty(searchString)){
                catalogos = catalogos.Where(s => s.Direccion.Contains(searchString)); 
                
            }else{
               catalogos = catalogos.Where(s => s.Status.Equals("D"));  
            }
        
            return View(await catalogos.ToListAsync());
        }
        public async Task<IActionResult> Add(int? id)
        {
            var userID = _userManager.GetUserName(User);
            if(userID == null){              
                

                List<Catalogo> catalogos = new List<Catalogo>();
                return  View("InmueblesL",catalogos);
            }else{

                var catalogo = await _context.Catalogo.FindAsync(id);
                Carrito carrito = new Carrito();
                carrito.Usuario = userID;       
                carrito.Price = catalogo.Price; 
                carrito.Direccion = catalogo.Direccion;
                carrito.Name = catalogo.Name;   
                carrito.Catalogo = catalogo;     
                _context.Add(carrito);
                await _context.SaveChangesAsync();
                return  RedirectToAction(nameof(Inmuebles));
             }
        }        
         
    }
}