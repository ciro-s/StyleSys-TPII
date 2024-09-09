using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsToUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nickname",
                table: "Usuario",
                newName: "us_telefono");

            migrationBuilder.AddColumn<string>(
                name: "us_apellido",
                table: "Usuario",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "us_clave",
                table: "Usuario",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "us_email",
                table: "Usuario",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "us_estado",
                table: "Usuario",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "us_fechaNacimiento",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "us_nickname",
                table: "Usuario",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "us_nombre",
                table: "Usuario",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "rol_nombre",
                table: "Rol",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "rol_descripcion",
                table: "Rol",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "UNQ_EMAIL",
                table: "Usuario",
                column: "us_email");

            migrationBuilder.AddUniqueConstraint(
                name: "UNQ_NICKNAME",
                table: "Usuario",
                column: "us_nickname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "UNQ_EMAIL",
                table: "Usuario");

            migrationBuilder.DropUniqueConstraint(
                name: "UNQ_NICKNAME",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_apellido",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_clave",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_email",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_estado",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_fechaNacimiento",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_nickname",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "us_nombre",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "us_telefono",
                table: "Usuario",
                newName: "nickname");

            migrationBuilder.AlterColumn<string>(
                name: "rol_nombre",
                table: "Rol",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "rol_descripcion",
                table: "Rol",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);
        }
    }
}
