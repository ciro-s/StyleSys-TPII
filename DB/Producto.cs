using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using FluentValidation;

namespace DB
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_producto { get; set; }

        [Required]
        public int id_categoria { get; set; }

        [ForeignKey("id_categoria")]
        public Categoria categoria { get; set; }

        [Required]
        public int id_proveedor { get; set; }

        [ForeignKey("id_proveedor")]
        public Proveedor proveedor { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string pr_nombre { get; set; }

        [Required]
        public bool pr_estado { get; set; }

        [Required]
        public float pr_precioVenta { get; set; }

        [Required]
        public float pr_precioCompra { get; set; }

        [Required]
        public int pr_stock { get; set; }

        [Required]
        public int pr_stockMinimo { get; set; }
    }

    public class ProductoValidator : AbstractValidator<Producto>
    {
        public ProductoValidator()
        {
            RuleFor(producto => producto.pr_nombre)
                .NotNull().WithMessage("El nombre es requerido.")
                .Matches(@"^[a-zA-Z0-9\s]+$").WithMessage("El nombre solo puede contener letras, numeros y espacios.")
                .Length(3, 30).WithMessage("El nombre debe contener entre 3 y 20 caracteres");

            RuleFor(producto => producto.pr_precioVenta)
                .NotNull().WithMessage("El precio de venta es requerido")
                .GreaterThan(0).WithMessage("El precio de venta debe ser mayor a 0")
                .GreaterThan(producto => producto.pr_precioCompra).WithMessage("El precio de venta debe ser mayor al de compra")
                .Must(value => decimal.TryParse(value.ToString(), out _)).WithMessage("El precio de venta debe ser un número decimal.");

            RuleFor(producto => producto.pr_precioCompra)
                .NotNull().WithMessage("El precio de venta es requerido")
                .GreaterThan(0).WithMessage("El precio de compra debe ser mayor a 0")
                .Must(value => decimal.TryParse(value.ToString(), out _)).WithMessage("El precio de compra debe ser un número decimal.");

            RuleFor(producto => producto.pr_stockMinimo)
                .NotNull().WithMessage("El stock minimo es requerido")
                .GreaterThan(-1).WithMessage("El stock minimo debe ser 0 ó mayor")
                .Must(value => int.TryParse(value.ToString(), out _)).WithMessage("El stock minimo debe ser un número decimal.");
        }
    }
}
