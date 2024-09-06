using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Usuario
    {
        [Key] //Vuelve llave primaria al atributo
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Lo hace autoincremental
        public int id_usuario {  get; set; }
        [Required]
        public string nickname { get; set; }
        [Required]
        public int id_rol {  get; set; }

        [ForeignKey("id_rol")]
        public virtual Rol Rol { get; set; }
    }
}
