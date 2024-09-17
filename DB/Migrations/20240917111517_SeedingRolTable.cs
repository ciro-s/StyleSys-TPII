using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class SeedingRolTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "id_rol", "rol_descripcion", "rol_estado", "rol_nombre" },
                values: new object[,]
                {
                    { 1, "Encargado principalmente de vender los artículos.", true, "Empleado" },
                    { 2, "Gestión de productos, usuarios, proveedores y reportes.", true, "Administrador" },
                    { 3, "Gestión de usuarios y permisos.", true, "Super Administrador" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "id_rol",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "id_rol",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "id_rol",
                keyValue: 3);
        }
    }
}
