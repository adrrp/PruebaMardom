using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProgramaAlmacen.Models
{
    public class Articulo_Proveedores
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Código del Artículo")]
        public string Codigo_articulo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public int Almacen_id { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public bool Estatus { get; set; }
    }
}
