using System;
using System.ComponentModel.DataAnnotations;

namespace HolaMundo.Models
{
    public abstract class ObjetoEscuelaBase
    {
        
        public  virtual string Nombre {get;set;}
        public string Id { get; set; }
        
        //public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}