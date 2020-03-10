using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ProgramaAlmacen.Models
{
    public class Articulo
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Código del Artículo")]
        public string Codigo_articulo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Marca")]
        public string Marca_articulo { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Precio de Compra")]
        public decimal Precio_compra { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Precio de Venta")]
        public decimal Precio_venta { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Ganancias")]
        public decimal Ganancias { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public bool Estatus { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Fecha de ingreso del producto")]
        public DateTime Fecha_ingreso { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [Display(Name = "Fecha de venta del producto")]
        public DateTime Fecha_venta { get; set; }
    }
}
