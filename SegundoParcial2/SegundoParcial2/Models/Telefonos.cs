using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SegundoParcial2.Models
{
    public class Telefonos
    {
        [Key]

        public int LlamadaId { get; set; }
     
        public string Problema { get; set; }
        public string Solucion { get; set; }
        //public TelefonoLlamadas ();

        public Telefonos ()
        {
            LlamadaId = 0;
            
            Problema = string.Empty;
            Solucion = string.Empty;
        }
    }
}
