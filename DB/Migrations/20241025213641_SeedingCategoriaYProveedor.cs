using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCategoriaYProveedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "prov_cuit",
                table: "Proveedor",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "id_categoria", "cat_descripcion", "cat_estado", "cat_nombre" },
                values: new object[,]
                {
                    { 1, "Abrigos rusticos y frizados.", true, "Buzos" },
                    { 2, "Remeras unisex.", true, "Remeras" },
                    { 3, "Jeans, joggins y pantalones.", true, "Pantalones" }
                });

            migrationBuilder.InsertData(
                table: "Proveedor",
                columns: new[] { "id_proveedor", "prov_cuit", "prov_descripcion", "prov_direccion", "prov_estado", "prov_nombre", "prov_razonSocial", "prov_telefono" },
                values: new object[] { 1, 27369665228L, "Talleristas, tejedores, bordadores y estampadores.", "Brasil 865", true, "Semillero", "Semillero textil S.A.", "3794558866" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "id_categoria",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "id_categoria",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "id_categoria",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Proveedor",
                keyColumn: "id_proveedor",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "prov_cuit",
                table: "Proveedor",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
