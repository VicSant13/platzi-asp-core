using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult create()
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();

              var cursos = (from curs in _context.Cursos select curs).ToList();
                var lista = new List<SelectListItem>();
                foreach (Curso curs in cursos)
                {
                    lista.Add(new SelectListItem { Text = curs.Nombre, Value = curs.Id });
                }
                ViewBag.Cursos = lista;
            ViewBag.Fecha = DateTime.Now;
            return View();
        }

        [HttpPost]
        public IActionResult create(Alumno alumno)
        {
            if(ModelState.IsValid){                        
            _context.Alumnos.Add(alumno);
            _context.SaveChanges();
            ViewBag.Fecha = DateTime.Now;
            ViewBag.MensajeExtra = "Vista creada";
            return  View("MultiAlumno", _context.Alumnos);
            }else{
                return View(alumno);
            }            
        }
        
        [Route("Alumno/Edit/{id}")]
        public IActionResult edit(string id)
        {   
            if(!string.IsNullOrWhiteSpace(id))
            {
                var alumno = from al in _context.Alumnos where al.Id == id select al;
                var cursos = (from curs in _context.Cursos select curs).ToList();
                var lista = new List<SelectListItem>();
                foreach (Curso curs in cursos)
                {
                    lista.Add(new SelectListItem { Text = curs.Nombre, Value = curs.Id });
                }
                ViewBag.Cursos = lista;
                ViewBag.Fecha = DateTime.Now;             
                return View(alumno.SingleOrDefault());
            }
            return  View("MultiAlumno", _context.Alumnos);
        }


        [HttpPost]
        [Route("Alumno/Edit/{id}")]
        public IActionResult edit(Alumno alumno, string id)
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            if(ModelState.IsValid){
                alumno.Id = id;          
                _context.Alumnos.Update(alumno);
                _context.SaveChanges();
                ViewBag.Fecha = DateTime.Now;
                ViewBag.MensajeExtra = "Vista creada";
                return View("Index", alumno);
            }else{
                return View(alumno);
            }            
        }

        [Route("Alumno/delete/{id}")]
        public IActionResult delete(string id)
        {
            var alumnoDelete = from alumno in _context.Alumnos
                                where alumno.Id == id
                                select alumno;

            
            _context.Alumnos.Remove(alumnoDelete.SingleOrDefault());
            _context.SaveChanges();
            return View("MultiAlumno",_context.Alumnos);
        }



        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}