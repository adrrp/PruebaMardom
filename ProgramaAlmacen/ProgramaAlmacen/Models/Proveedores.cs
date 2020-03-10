using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProgramaAlmacen.Models
{
    public class Proveedores
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Código del Proveedor")]
        public string Codigo_proveedor { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Correo_electronico { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Ubicacion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Articulos { get; set; }
    }
}
