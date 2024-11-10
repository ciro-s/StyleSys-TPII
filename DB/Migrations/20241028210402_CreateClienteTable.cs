using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateClienteTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cl_nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cl_apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cl_dni = table.Column<int>(type: "int", nullable: false),
                    cl_email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cl_telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cl_fechaNacimiento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cl_fechaAlta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cl_estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id_cliente);
                    table.UniqueConstraint("UNQ_DNIcliente", x => x.cl_dni);
                    table.UniqueConstraint("UNQ_EMAILCliente", x => x.cl_email);
                });

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "id_rol",
                keyValue: 2,
                column: "rol_descripcion",
                value: "Gestión de productos, usuarios, proveedores y reportes.");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1,
                columns: new[] { "us_clave", "us_fechaNacimiento" },
                values: new object[] { "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", new DateTime(2024, 10, 28, 18, 4, 2, 59, DateTimeKind.Local).AddTicks(5444) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "us_email",
                table: "Usuario",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Rol",
                keyColumn: "id_rol",
                keyValue: 2,
                column: "rol_descripcion",
                value: "Gestión de productos, usuarios, proveedores, compras y reportes.");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1,
                columns: new[] { "us_clave", "us_fechaNacimiento" },
                values: new object[] { "clavehash", new DateTime(2024, 9, 17, 8, 25, 16, 207, DateTimeKind.Local).AddTicks(5236) });
        }
    }
}
