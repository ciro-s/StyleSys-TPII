using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class VentaDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_detalle { get; set; }

        public int id_cabecera { get; set; }

        public int id_producto { get; set; }

        [ForeignKey("id_cabecera")]
        public VentaCabecera cabecera { get; set; }

        [ForeignKey("id_producto")]
        public Producto producto { get; set; }

        [Required]
        public float precio_venta { get; set; }

        [Required]
        public int cantidad { get; set; }
    }
}
