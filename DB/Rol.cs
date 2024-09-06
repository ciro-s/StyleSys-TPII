using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_rol { get; set; }
        [Required]
        public string rol_nombre { get; set; }
        [AllowNull]
        public string rol_descripcion { get; set; }
        [Required]
        public bool rol_estado { get; set; }


        public virtual ICollection<Usuario> usuarios { get; set; }
    }
}
