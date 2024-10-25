using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateCategoriaProveedorTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id_categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cat_descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cat_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id_categoria);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    id_proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prov_razonSocial = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    prov_cuit = table.Column<int>(type: "int", nullable: false),
                    prov_nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    prov_descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    prov_telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    prov_direccion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    prov_estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.id_proveedor);
                    table.UniqueConstraint("UNQ_CUIT", x => x.prov_cuit);
                });

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 2,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 3,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5399));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 1,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 9, 27, 11, 26, 15, 70, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 2,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 9, 27, 11, 26, 15, 70, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id_usuario",
                keyValue: 3,
                column: "us_fechaNacimiento",
                value: new DateTime(2024, 9, 27, 11, 26, 15, 70, DateTimeKind.Local).AddTicks(5810));
        }
    }
}
