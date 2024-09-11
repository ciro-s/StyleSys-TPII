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
        [StringLength(20, MinimumLength=3)]
        public string rol_nombre { get; set; }

        [AllowNull]
        [StringLength (60)]
        public string rol_descripcion { get; set; }

        [Required]
        public bool rol_estado { get; set; }


        public virtual ICollection<Usuario> usuarios { get; set; }
    }
}
