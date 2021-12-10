using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;
using System.Linq;

namespace HolaMundo.Controllers
{
    public class AlumnoController : Controller
    {
        /*[Route("Alumno/Index")]
        [Route("Alumno/Index/{id}")]*/
        public IActionResult Index(string id)
        {
           
            if(!string.IsNullOrWhiteSpace(id)){
                var alumno = from asig in _context.Alumnos
                                    where asig.Id == id
                                    select asig;

                return View(alumno.SingleOrDefault());
            }else{
                return View("MultiAlumno",_context.Alumnos);
            }
        }
        public IActionResult MultiAlumno()
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            ViewBag.CosaDinamica = "Bonjour";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Alumnos);
        }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}