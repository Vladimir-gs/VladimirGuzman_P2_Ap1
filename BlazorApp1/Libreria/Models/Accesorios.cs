using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Models
{
    public class Accesorios
    {
        [Key] 
        public int AccesorioId { get; set; }
        [Required(ErrorMessage ="Este campo no puede quedar vacio")]
        public string? Descripcion { get; set; }
    }
}
