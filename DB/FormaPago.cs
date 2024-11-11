using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class FormaPago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_formaPago { get; set; }

        [Required]
        [StringLength(30)]
        public string fp_nombre { get; set; }

        [StringLength(60)]
        public string fp_descripcion { get; set; }
    }
}
