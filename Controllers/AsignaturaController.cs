using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;

namespace HolaMundo.Controllers
{
    public class AsignaturaController : Controller
    {

        /*public IActionResult Index()
        {
         var asignatura = new Asignatura{
                 Id = Guid.NewGuid().ToString(),
                 Nombre = "Programación avanzada"
             };

            ViewBag.CosaDinamica = "Bonjour";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Asignaturas.FirstOrDefault());
        }*/
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
           
            if(!string.IsNullOrWhiteSpace(asignaturaId)){
                var asignatura = from asig in _context.Asignaturas
                                    where asig.Id == asignaturaId
                                    select asig;

                return View(asignatura.SingleOrDefault());
            }else{
                return View("MultiAsignatura",_context.Asignaturas);
            }
        }
        public IActionResult MultiAsignatura()
        {

            ViewBag.CosaDinamica = "Bonjour";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
    
}