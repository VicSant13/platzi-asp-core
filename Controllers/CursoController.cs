using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;
using System.Linq;

namespace HolaMundo.Controllers
{
    public class CursoController : Controller
    {       
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

         [Route("Curso/edit/{id}")]
        public IActionResult edit(string id)
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
             var curso = from cursos in _context.Cursos
                                where cursos.Id == id
                                select cursos;

            ViewBag.Fecha = DateTime.Now;
            return View(curso.SingleOrDefault());
        }

        [HttpPost]
        public IActionResult create(Curso curso)
        {
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

        [HttpPost]
        [Route("Curso/Edit/{id}")]
        public IActionResult edit(Curso curso, string id)
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            if(ModelState.IsValid){
                curso.Id = id;          
                _context.Cursos.Update(curso);
                _context.SaveChanges();
                ViewBag.Fecha = DateTime.Now;
                ViewBag.MensajeExtra = "Vista creada";
                return View("Index", curso);
            }else{
                return View(curso);
            }            
        }

        [Route("Curso/delete/{id}")]
        public IActionResult delete(string id)
        {
            var cursoDelete = from curso in _context.Cursos
                                where curso.Id == id
                                select curso;

            
            _context.Cursos.Remove(cursoDelete.SingleOrDefault());
            _context.SaveChanges();
            return View("MultiCurso",_context.Cursos);
        }


        private EscuelaContext _context;
        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}