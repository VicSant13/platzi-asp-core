using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;
using System.Linq;

namespace HolaMundo.Controllers
{
    public class CursoController : Controller
    {
        /*[Route("Alumno/Index")]
        [Route("Alumno/Index/{id}")]*/
        public IActionResult Index(string id)
        {
           
            if(!string.IsNullOrWhiteSpace(id)){
                var cursos = from asig in _context.Cursos
                                    where asig.Id == id
                                    select asig;

                return View(cursos.SingleOrDefault());
            }else{
                return View("MultiCurso",_context.Cursos);
            }
        }
        public IActionResult MultiCurso()
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            ViewBag.CosaDinamica = "Bonjour";
            ViewBag.Fecha = DateTime.Now;
            return View(_context.Cursos);
        }
        public IActionResult create()
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            
            ViewBag.Fecha = DateTime.Now;
            return View();
        }

        [HttpPost]
        public IActionResult create(Curso curso)
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            if(ModelState.IsValid){

            
            var escuela = _context.Escuelas.FirstOrDefault();
            curso.EscuelaId = escuela.Id;
            
            _context.Cursos.Add(curso);
            _context.SaveChanges();


            ViewBag.Fecha = DateTime.Now;
            ViewBag.MensajeExtra = "Vista creada";
            return View("Index", curso);
            }else{
                return View(curso);
            }
            
        }



        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}