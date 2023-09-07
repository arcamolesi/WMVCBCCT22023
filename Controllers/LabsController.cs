using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;
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

        public IActionResult Banana()
        {
                return View();  
        }

       // [HttpGet]
        public IActionResult Create()
        {
            return View();  
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descricao,quantidade,situacao")] Sala sala)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sala);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sala);
        }
    }
}
