using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CorreccionVentaDetalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VentaDetalle_Compra_id_cabecera",
                table: "VentaDetalle");

            migrationBuilder.AddForeignKey(
                name: "FK_VentaDetalle_Venta_id_cabecera",
                table: "VentaDetalle",
                column: "id_cabecera",
                principalTable: "Venta",
                principalColumn: "id_cabecera",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VentaDetalle_Venta_id_cabecera",
                table: "VentaDetalle");

            migrationBuilder.DropUniqueConstraint(
                name: "UNQ_COD_V",
                table: "Venta");

            migrationBuilder.AddUniqueConstraint(
                name: "UNQ_COD",
                table: "Venta",
                column: "cod_cabecera");

            migrationBuilder.AddForeignKey(
                name: "FK_VentaDetalle_Compra_id_cabecera",
                table: "VentaDetalle",
                column: "id_cabecera",
                principalTable: "Compra",
                principalColumn: "id_cabecera",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
