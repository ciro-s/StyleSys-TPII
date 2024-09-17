using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class SeedingUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "id_usuario", "id_rol", "us_apellido", "us_clave", "us_direccion", "us_dni", "us_email", "us_estado", "us_fechaNacimiento", "us_nickname", "us_nombre", "us_telefono" },
                values: new object[] { 1, 3, "Solalinde", "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", "Calle Ficticia 123", 43205377, "admin@maill.com", true, new DateTime(2024, 9, 17, 8, 25, 16, 207, DateTimeKind.Local).AddTicks(5236), "admin", "Ciro", "3794143742" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1);
        }
    }
}
