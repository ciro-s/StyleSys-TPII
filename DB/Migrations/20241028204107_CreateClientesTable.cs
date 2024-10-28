using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateClientesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 10, 28, 17, 41, 6, 612, DateTimeKind.Local).AddTicks(6518));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 10, 28, 17, 36, 56, 615, DateTimeKind.Local).AddTicks(8546));
        }
    }
}
