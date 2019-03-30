using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace almacen.Models
{   public enum TipoEstado
    {
        Avtivo,
        Inactivo
    }
    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }

    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Nombre del producto")]
        public string Nombre { get; set; }
        public int Precio { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public TipoUnidad Unidad { get; set; }
        [Required]
        public TipoEstado Estado { get; set; }

    }
}