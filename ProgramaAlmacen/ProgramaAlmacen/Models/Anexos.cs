using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramaAlmacen.Models
{
    public class Anexos
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Archivo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Código del Artículo")]
        public string Codigo_articulo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public bool Estatus { get; set; }
    }
}
