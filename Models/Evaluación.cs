using System;

namespace HolaMundo.Models
{
    public class Evaluación:ObjetoEscuelaBase
    {
        /*se hace referencia al hijo*/
        public Alumno Alumno { get; set; }
        /*se hace referencia al padre*/
        public string AlumnoId  { get; set;}
    
        public Asignatura Asignatura  { get; set; }

        public string AsignaturaId { get; set; }
        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}