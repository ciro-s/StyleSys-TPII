using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class VentaCabecera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_cabecera { get; set; }

        [Required]
        public long cod_cabecera { get; set; }

        [Required]
        public int id_usuario { get; set; }

        [ForeignKey("id_usuario")]
        public Usuario usuario { get; set; }

        [Required]
        public int id_cliente { get; set; }

        [ForeignKey("id_cliente")]
        public Cliente cliente { get; set; }

        [Required]
        public int id_formaPago { get; set; }

        [ForeignKey("id_formaPago")]
        public FormaPago formaPago { get; set; }

        [Required]
        public float monto_total { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fecha_registro { get; set; }
    }
}
