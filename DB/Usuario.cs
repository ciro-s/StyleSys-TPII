using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DB.UsuarioValidator;

namespace DB
{
    public class Usuario
    {
        [Key] //Vuelve llave primaria al atributo
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Lo hace autoincremental
        public int id_usuario { get; set; }

        [Required(ErrorMessage = "El campo DNI es requerido.")]
        public int us_dni { get; set; }

        [Required(ErrorMessage="El campo nombre es requerido.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 20 caracteres.")]
        public string us_nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido es requerido.")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El apellido debe tener entre 2 y 20 caracteres.")]
        public string us_apellido { get; set; }

        //[Required(ErrorMessage = "El campo email es requerido.")]
        //[StringLength(40, ErrorMessage = "El mail debe tener máximo 20 caracteres.")]
        //[EmailAddress]
        public string us_email { get; set; }

        [Required(ErrorMessage = "El campo direccion es requerido.")]
        [StringLength(50, MinimumLength=4, ErrorMessage="La dirección debe tener entre 4 y 50 caracteres.")]
        public string us_direccion { get; set; }

        [RegularExpression(@"/^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$/", ErrorMessage = "Ingrese un número de telefono válido.")]
        public string us_telefono { get; set; }

        [Required(ErrorMessage = "El campo contraseña es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(80, MinimumLength = 6)]
        public string us_clave { get; set; }

        [Required(ErrorMessage = "El campo fecha de nacimiento es requerido.")]
        [DataType(DataType.Date)]
        public DateTime us_fechaNacimiento { get; set; }

        [Required]
        public bool us_estado { get; set; }

        [Required(ErrorMessage = "El campo username es requerido.")]
        [StringLength(20, ErrorMessage = "El campo nickname tiene un máximo de caracteres es de 20 y el mínimo de 4", MinimumLength=4)]
        public string us_nickname { get; set; }

        [Required(ErrorMessage = "El campo rol es requerido.")]
        public int id_rol {  get; set; }

        [ForeignKey("id_rol")] //Se define el constraint de la relación entre tablas
        public virtual Rol Rol { get; set; }
    }

    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        private readonly List<int> _dnisExistentes;
        private readonly List<string> _emailExistentes;
        private readonly List<string> _nicksExistentes;
        public UsuarioValidator(List<int> dnisExistentes, List<string> emailExistentes, List<string> nicksExistentes, bool updating)
        {
            _dnisExistentes = dnisExistentes;
            _emailExistentes = emailExistentes;
            _nicksExistentes = nicksExistentes;

            if (!updating)
            {
                RuleFor(usuario => usuario.us_dni)
                    .Must(dni => !_dnisExistentes.Contains(dni))
                    .WithMessage("Ya existe un usuario con ese DNI.");

                RuleFor(usuario => usuario.us_email)
                    .Must(mail => !_emailExistentes.Contains(mail))
                    .WithMessage("Ya existe un usuario con ese eMail.");

                RuleFor(usuario => usuario.us_nickname)
                    .Must(nick => !_nicksExistentes.Contains(nick))
                    .WithMessage("Ya existe un usuario con ese nickname.");
            }
            
            RuleFor(usuario => usuario.us_dni)
                .NotNull().WithMessage("El DNI es requerido.")
                .GreaterThan(1000000).WithMessage("ingrese un DNI válido");
                
            RuleFor(usuario => usuario.us_nombre)
                .NotNull().WithMessage("El nombre es requerido.")
                .Must(nombre => nombre.All(char.IsLetter)).WithMessage("El nombre solo puede contener letras.")
                .Length(2, 20).WithMessage("El nombre debe contener entre 2 y 20 caracteres");

            RuleFor(usuario => usuario.us_apellido)
                .NotNull().WithMessage("El apellido es requerido.")
                .Must(apellido => apellido.All(char.IsLetter))
                .WithMessage("El apellido solo puede contener letras.")
                .Length(2, 20).WithMessage("El nombre debe contener entre 2 y 20 caracteres");

            RuleFor(usuario => usuario.us_direccion)
                .NotNull().WithMessage("La direccion es requerida")
                .Length(4, 50).WithMessage("La dirección debe contener entre 4 y 50 caracteres");

            RuleFor(usuario => usuario.us_telefono)
                .NotNull().WithMessage("El telefono es requerido")
                .Length(10, 20).WithMessage("El número de teléfono debe tener entre 10 y 20 caracteres.");

            RuleFor(usuario => usuario.us_email)
                .NotNull().WithMessage("El mail es requerido.")
                .NotEmpty().WithMessage("El mail es requerido.")
                .EmailAddress().WithMessage("Ingrese un correo electrónico válido.");

            RuleFor(usuario => usuario.us_clave)
                .NotNull().WithMessage("La contraseña es requerido.")
                .Must(clave => clave.Any(char.IsDigit))
                .WithMessage("La contraseña debe contener al menos un número.");

            RuleFor(usuario => usuario.us_nickname)
                .NotNull().WithMessage("El usuario es requerido.")
                .Must(nickname => nickname.All(char.IsLetterOrDigit))
                .WithMessage("El nickname solo puede contener letras y números.");
        }
    }
}
