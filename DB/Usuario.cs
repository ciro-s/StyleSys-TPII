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
        public int id_usuario { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 20 caracteres.")]
        public string us_nombre { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 20 caracteres.")]
        public string us_apellido { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "El mail debe tener máximo 20 caracteres.")]
        [EmailAddress]
        public string us_email { get; set; }

        [RegularExpression(@"/^(?:\\+?54)?\\d{10}$", ErrorMessage = "Ingrese un número de telefono válido.")]
        public string us_telefono { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(80, MinimumLength = 6)]
        public string us_clave { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime us_fechaNacimiento { get; set; }

        [Required]
        public bool us_estado { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El campo nickname tiene un máximo de caracteres es de 20 y el mínimo de 4", MinimumLength=4)]
        public string us_nickname { get; set; }

        [Required]
        public int id_rol {  get; set; }

        [ForeignKey("id_rol")] //Se define el constraint de la relación entre tablas
        public virtual Rol Rol { get; set; }
    }
}
