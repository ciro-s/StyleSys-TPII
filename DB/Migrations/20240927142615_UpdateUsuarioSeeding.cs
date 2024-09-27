using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUsuarioSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "us_email",
                table: "Usuario",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

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
                values: new object[] { "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", new DateTime(2024, 9, 27, 11, 26, 15, 70, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "id_usuario", "id_rol", "us_apellido", "us_clave", "us_direccion", "us_dni", "us_email", "us_estado", "us_fechaNacimiento", "us_nickname", "us_nombre", "us_telefono" },
                values: new object[,]
                {
                    { 2, 2, "Luna", "ae571eafd64e7aed0e74610a624cb273ccb741334913730acc1717ef04e28857", "Calle Ficticia 123", 41333654, "mluna@maill.com", true, new DateTime(2024, 9, 27, 11, 26, 15, 70, DateTimeKind.Local).AddTicks(5808), "mluna", "Maximiliano", "3794253368" },
                    { 3, 1, "Lopez", "37705012ac2afebf8b66739074b7b4401c48d9497e42bc588d176870fa738f70", "Calle Ficticia 123", 32541569, "llopez@maill.com", true, new DateTime(2024, 9, 27, 11, 26, 15, 70, DateTimeKind.Local).AddTicks(5810), "llopez", "Lucas", "3795266551" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 3);

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
