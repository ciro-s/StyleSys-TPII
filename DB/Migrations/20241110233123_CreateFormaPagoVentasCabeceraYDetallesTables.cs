using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class CreateFormaPagoVentasCabeceraYDetallesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormaPago",
                columns: table => new
                {
                    id_formaPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fp_nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    fp_descripcion = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPago", x => x.id_formaPago);
                });

            migrationBuilder.CreateTable(
                name: "VentaDetalle",
                columns: table => new
                {
                    id_detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_cabecera = table.Column<int>(type: "int", nullable: false),
                    id_producto = table.Column<int>(type: "int", nullable: false),
                    precio_venta = table.Column<float>(type: "real", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VentaDetalle", x => x.id_detalle);
                    table.ForeignKey(
                        name: "FK_VentaDetalle_Compra_id_cabecera",
                        column: x => x.id_cabecera,
                        principalTable: "Compra",
                        principalColumn: "id_cabecera",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VentaDetalle_Producto_id_producto",
                        column: x => x.id_producto,
                        principalTable: "Producto",
                        principalColumn: "id_producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    id_cabecera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cod_cabecera = table.Column<long>(type: "bigint", nullable: false),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false),
                    id_formaPago = table.Column<int>(type: "int", nullable: false),
                    monto_total = table.Column<float>(type: "real", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.id_cabecera);
                    table.UniqueConstraint("UNQ_COD_V", x => x.cod_cabecera);
                    table.ForeignKey(
                        name: "FK_Venta_Cliente_id_cliente",
                        column: x => x.id_cliente,
                        principalTable: "Cliente",
                        principalColumn: "id_cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_FormaPago_id_formaPago",
                        column: x => x.id_formaPago,
                        principalTable: "FormaPago",
                        principalColumn: "id_formaPago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Venta_Usuario_id_usuario",
                        column: x => x.id_usuario,
                        principalTable: "Usuario",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FormaPago",
                columns: new[] { "id_formaPago", "fp_descripcion", "fp_nombre" },
                values: new object[,]
                {
                    { 1, "Billetes", "Efectivo" },
                    { 2, "Mastercard, Visa, Tarjetas de billeteras virtuales", "Tarjeta de débito" },
                    { 3, "La acreditación depende del banco", "Tarjeta de Crédito" },
                    { 4, "Para billeteras virtuales (MP, MODO)", "QR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Venta_id_cliente",
                table: "Venta",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_id_formaPago",
                table: "Venta",
                column: "id_formaPago");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_id_usuario",
                table: "Venta",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalle_id_cabecera",
                table: "VentaDetalle",
                column: "id_cabecera");

            migrationBuilder.CreateIndex(
                name: "IX_VentaDetalle_id_producto",
                table: "VentaDetalle",
                column: "id_producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "VentaDetalle");

            migrationBuilder.DropTable(
                name: "FormaPago");
        }
    }
}
