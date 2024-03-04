using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    public class VehiculosDetalle
    {
        [Key] 
        public int DetalleId { get; set; }
        [ForeignKey("Vehiculos")]
        public int VehiculosId { get; set; }
        [ForeignKey("Accesorios")]
        public int AccesoriosId { get; set; }
        [Range(0, float.MaxValue, ErrorMessage ="Este valor no puede ser menor que cero")]
        public float valor {  get; set; }

    }
}
