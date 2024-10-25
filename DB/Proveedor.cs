using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_proveedor { get; set; }

        [Required]
        [StringLength(40)]
        public string prov_razonSocial { get; set; }

        [Required]
        public int prov_cuit { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string prov_nombre { get; set; }

        [AllowNull]
        [StringLength(60)]
        public string prov_descripcion { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 10)]
        public string prov_telefono { get; set; }

        [Required]
        [StringLength (60, MinimumLength = 4)]
        public string prov_direccion { get; set; }

        [Required]
        public bool prov_estado { get; set; }

    }
}
