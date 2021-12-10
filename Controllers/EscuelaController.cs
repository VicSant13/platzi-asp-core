using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;

namespace HolaMundo.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context;
        public IActionResult Index()
        {                                
            ViewBag.CosaDinamica = "Le morgue";
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}