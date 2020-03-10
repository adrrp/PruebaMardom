using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaAlmacen.Models
{
    public class Almacenes
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Correo Electrónico")]
        public string Correo_electronico { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Ubicacion { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Capacidad de Articulos")]
        public int Capacidad_articulos { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public string Proveedores { get; set; }
    }
}
