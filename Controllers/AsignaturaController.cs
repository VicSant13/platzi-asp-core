using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HolaMundo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HolaMundo.Controllers
{
    public class AsignaturaController : Controller
    {


       /* [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{id}")]*/
        public IActionResult Index(string id)
        {
           
            if(!string.IsNullOrWhiteSpace(id)){
                var asignatura = from asig in _context.Asignaturas
                                    where asig.Id == id
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
        public IActionResult create(Asignatura asignatura)
        {
            if(ModelState.IsValid){                        
            _context.Asignaturas.Add(asignatura);
            _context.SaveChanges();
            ViewBag.Fecha = DateTime.Now;
            ViewBag.MensajeExtra = "Vista creada";
            return  View("MultiAsignatura", _context.Asignaturas);
            }else{
                return View(asignatura);
            }            
        }

        [Route("Asignatura/Edit/{id}")]
        public IActionResult edit(string id)
        {   
            if(!string.IsNullOrWhiteSpace(id))
            {
                var asignatura = from asig in _context.Asignaturas where asig.Id == id select asig;
                var cursos = (from curs in _context.Cursos select curs).ToList();
                var lista = new List<SelectListItem>();
                foreach (Curso curs in cursos)
                {
                    lista.Add(new SelectListItem { Text = curs.Nombre, Value = curs.Id });
                }
                ViewBag.Cursos = lista;
                ViewBag.Fecha = DateTime.Now;             
                return View(asignatura.SingleOrDefault());
            }
            return  View("MultiAsignatura", _context.Asignaturas);
        }


        [HttpPost]
        [Route("Asignatura/Edit/{id}")]
        public IActionResult edit(Asignatura asignatura, string id)
        {
            //var listaAlumnos = GenerarAlumnosAlAzar();
            if(ModelState.IsValid){
                asignatura.Id = id;          
                _context.Asignaturas.Update(asignatura);
                _context.SaveChanges();
                ViewBag.Fecha = DateTime.Now;
                ViewBag.MensajeExtra = "Vista creada";
                return View("Index", asignatura);
            }else{
                return View(asignatura);
            }            
        }

        [Route("Asignatura/delete/{id}")]
        public IActionResult delete(string id)
        {
            var asignaturaDelete = from asignatura in _context.Asignaturas
                                where asignatura.Id == id
                                select asignatura;

            
            _context.Asignaturas.Remove(asignaturaDelete.SingleOrDefault());
            _context.SaveChanges();
            return View("MultiAsignatura",_context.Asignaturas);
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
    
}