using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libreria.Models
{
    public class Vehiculos
    {
        [Key] 
        public int VehiculoId { get; set; }
        [ForeignKey("Accesorios")]
        public int AccesoriosId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage ="Este campo no puede estar vacio")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio")]
        [Range(1,float.MaxValue, ErrorMessage ="El precio no puede ser menor que 0")]
        public float Costo { get; set; }
        public float Gastos { get; set; }
    }
}
