using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMVCBCCT22023.Models;

namespace WMVCBCCT22023.Controllers
{
    public class LabsController : Controller
    {
        private readonly Contexto _context;


        public LabsController(Contexto context)
        {
            _context = context;
        }


        // GET: Salas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Salas.ToListAsync());
        }
    }
}
