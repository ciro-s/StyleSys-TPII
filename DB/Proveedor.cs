using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

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
        public long prov_cuit { get; set; }

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

    public class ProveedorValidator : AbstractValidator<Proveedor>
    {
        private readonly List<long> _cuitExistentes;

        public ProveedorValidator(List<long> cuitExistentes, bool updating)
        {
            _cuitExistentes = cuitExistentes;

            if (!updating)
            {
                RuleFor(proveedor => proveedor.prov_cuit)
                    .Must(cuit => !_cuitExistentes.Contains(cuit))
                    .WithMessage("Ya existe un proveedor con ese CUIT.");
            }

            RuleFor(proveedor => proveedor.prov_cuit)
                .NotNull().WithMessage("El CUIT es requerido.")
                .GreaterThan(1000000000).WithMessage("ingrese un CUIT válido");

            RuleFor(proveedor => proveedor.prov_nombre)
                .NotNull().WithMessage("El nombre es requerido.")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre solo puede contener letras y espacios.")
                .Length(3, 20).WithMessage("El nombre debe contener entre 3 y 20 caracteres");

            RuleFor(proveedor => proveedor.prov_razonSocial)
                .NotNull().WithMessage("La razon social es requerida.")
                .Length(4, 40).WithMessage("La razon social debe contener entre 4 y 40 caracteres");

            RuleFor(proveedor => proveedor.prov_direccion)
                .NotNull().WithMessage("La direccion es requerida")
                .Length(4, 60).WithMessage("La dirección debe contener entre 4 y 60 caracteres");

            RuleFor(proveedor => proveedor.prov_telefono)
                .NotNull().WithMessage("El telefono es requerido")
                .Matches(@"^(54)?([1-9][0-9]{3})([1-9][0-9]{5})$").WithMessage("Ingrese un número de teléfono válido")
                .Length(10, 15).WithMessage("El número de teléfono debe tener entre 10 y 15 caracteres.");

            RuleFor(proveedor => proveedor.prov_descripcion)
                .Length(0, 40).WithMessage("La descripcion debe contener como maximo 40 caracteres");
        }
    }
}
