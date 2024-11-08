using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateComprasTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    id_cabecera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_cabecera = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    monto_total = table.Column<float>(type: "real", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.id_cabecera);
                    table.UniqueConstraint("UNQ_COD", x => x.cod_cabecera);
                    table.ForeignKey(
                        name: "FK_Compra_Usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "id_producto", "id_categoria", "id_proveedor", "pr_estado", "pr_nombre", "pr_precioCompra", "pr_precioVenta", "pr_stock", "pr_stockMinimo" },
                values: new object[,]
                {
                    { 3, 3, 1, true, "Shorts adidas sharp 33", 9560f, 17110f, 0, 2 },
                    { 4, 2, 1, true, "Campera Nike urbana", 20100f, 37990f, 0, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_id_usuario",
                table: "Compra",
                column: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "id_producto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "id_producto",
                keyValue: 4);
        }
    }
}
