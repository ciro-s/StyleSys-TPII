using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using static DB.ClienteValidator;


namespace DB
{
    public class Cliente
    {
        [Key] //Vuelve llave primaria al atributo
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Lo hace autoincremental
        public int id_cliente { get; set; }

        [Required]
        public string cl_nombre { get; set; }

        [Required]
        public string cl_apellido { get; set; }

        [Required]
        public int cl_dni {get; set;}

        [Required]
        public string cl_email { get; set; }

        [Required]
        [RegularExpression(@"/^(?:(?:00)?549?)?0?(?:11|[2368]\d)(?:(?=\d{0,2}15)\d{2})??\d{8}$/", ErrorMessage = "Ingrese un número de telefono válido.")]

        public string cl_telefono { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime cl_fechaNacimiento { get; set; }

        [Required]
        public DateTime cl_fechaAlta { get; set; }

        [Required]
        public bool cl_estado { get; set; }
    }

    public class ClienteValidator : AbstractValidator<Cliente>
    {
        private readonly List<int> _dnisExistentes;
        private readonly List<string> _emailExistentes;
        public ClienteValidator(List<int> dnisExistentes, List<string> emailExistentes, bool updating)
        {
            _dnisExistentes = dnisExistentes;
            _emailExistentes = emailExistentes;

            if (!updating)
            {
                RuleFor(Cliente => Cliente.cl_dni)
                    .Must(dni => !_dnisExistentes.Contains(dni))
                    .WithMessage("Ya existe un usuario con ese DNI.");

                RuleFor(Cliente => Cliente.cl_email)
                    .Must(mail => !_emailExistentes.Contains(mail))
                    .WithMessage("Ya existe un usuario con ese eMail.");
            }

            RuleFor(Cliente => Cliente.cl_dni)
                .NotNull().WithMessage("El DNI es requerido.")
                .GreaterThan(1000000).WithMessage("ingrese un DNI válido");

            RuleFor(Cliente => Cliente.cl_nombre)
                .NotNull().WithMessage("El nombre es requerido.")
                .Must(nombre => nombre.All(char.IsLetter)).WithMessage("El nombre solo puede contener letras.")
                .Length(2, 20).WithMessage("El nombre debe contener entre 2 y 20 caracteres");

            RuleFor(Cliente => Cliente.cl_apellido)
                .NotNull().WithMessage("El apellido es requerido.")
                .Must(apellido => apellido.All(char.IsLetter))
                .WithMessage("El apellido solo puede contener letras.")
                .Length(2, 20).WithMessage("El nombre debe contener entre 2 y 20 caracteres");

            RuleFor(Cliente => Cliente.cl_telefono)
                .NotNull().WithMessage("El telefono es requerido")
                .Matches(@"^(54)?([1-9][0-9]{3})([1-9][0-9]{5})$").WithMessage("Ingrese un número de teléfono válido")
                .Length(10, 20).WithMessage("El número de teléfono debe tener entre 10 y 20 caracteres.");

            RuleFor(Cliente => Cliente.cl_email)
                .NotNull().WithMessage("El mail es requerido.")
                .NotEmpty().WithMessage("El mail es requerido.")
                .EmailAddress().WithMessage("Ingrese un correo electrónico válido.");
        }
        }

    }




