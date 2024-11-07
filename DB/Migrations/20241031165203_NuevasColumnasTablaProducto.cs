using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class NuevasColumnasTablaProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "prod_nombre",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "prod_estado",
                table: "Producto",
                newName: "pr_estado");

            migrationBuilder.AddColumn<int>(
                name: "id_proveedor",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "pr_nombre",
                table: "Producto",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "pr_precioCompra",
                table: "Producto",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "pr_precioVenta",
                table: "Producto",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "pr_stock",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pr_stockMinimo",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_id_proveedor",
                table: "Producto",
                column: "id_proveedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Proveedor_id_proveedor",
                table: "Producto",
                column: "id_proveedor",
                principalTable: "Proveedor",
                principalColumn: "id_proveedor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Proveedor_id_proveedor",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_id_proveedor",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "id_proveedor",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "pr_nombre",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "pr_precioCompra",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "pr_precioVenta",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "pr_stock",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "pr_stockMinimo",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "pr_estado",
                table: "Producto",
                newName: "prod_estado");

            migrationBuilder.AddColumn<string>(
                name: "prod_nombre",
                table: "Producto",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
