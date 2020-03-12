using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegundoParcial2.Models
{
    public class TelefonoLlamadas
    {
        [Key]
        public int LlamadaId { get; set; }
        [Required(ErrorMessage = "Debes Agregar una Descripcion")]
        public string Descripcion { get; set; }

        [ForeignKey("LlamadaDetalleId")]
        public List<Telefonos> Detalles { get; set; }
        public TelefonoLlamadas()
        {
            LlamadaId = 0;
            Descripcion = string.Empty;
            Detalles = new List<Telefonos>();
        }
    }
}
