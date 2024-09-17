﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(StyleSysContext))]
    partial class StyleSysContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Rol", b =>
                {
                    b.Property<int>("id_rol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_rol"));

                    b.Property<string>("rol_descripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("rol_estado")
                        .HasColumnType("bit");

                    b.Property<string>("rol_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id_rol");

                    b.ToTable("Rol", (string)null);

                    b.HasData(
                        new
                        {
                            id_rol = 1,
                            rol_descripcion = "Encargado principalmente de vender los artículos.",
                            rol_estado = true,
                            rol_nombre = "Empleado"
                        },
                        new
                        {
                            id_rol = 2,
                            rol_descripcion = "Gestión de productos, usuarios, proveedores, compras y reportes.",
                            rol_estado = true,
                            rol_nombre = "Administrador"
                        },
                        new
                        {
                            id_rol = 3,
                            rol_descripcion = "Gestión de usuarios y permisos.",
                            rol_estado = true,
                            rol_nombre = "Super Administrador"
                        });
                });

            modelBuilder.Entity("DB.Usuario", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_usuario"));

                    b.Property<int>("id_rol")
                        .HasColumnType("int");

                    b.Property<string>("us_apellido")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("us_clave")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("us_direccion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("us_dni")
                        .HasColumnType("int");

                    b.Property<string>("us_email")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("us_estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("us_fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("us_nickname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("us_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("us_telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_usuario");

                    b.HasAlternateKey("us_dni")
                        .HasName("UNQ_DNI");

                    b.HasAlternateKey("us_email")
                        .HasName("UNQ_EMAIL");

                    b.HasAlternateKey("us_nickname")
                        .HasName("UNQ_NICKNAME");

                    b.HasIndex("id_rol");

                    b.ToTable("Usuario", (string)null);

                    b.HasData(
                        new
                        {
                            id_usuario = 1,
                            id_rol = 3,
                            us_apellido = "Solalinde",
                            us_clave = "clavehash",
                            us_direccion = "Calle Ficticia 123",
                            us_dni = 43205377,
                            us_email = "admin@maill.com",
                            us_estado = true,
                            us_fechaNacimiento = new DateTime(2024, 9, 17, 8, 25, 16, 207, DateTimeKind.Local).AddTicks(5236),
                            us_nickname = "admin",
                            us_nombre = "Ciro",
                            us_telefono = "3794143742"
                        });
                });

            modelBuilder.Entity("DB.Usuario", b =>
                {
                    b.HasOne("DB.Rol", "Rol")
                        .WithMany("usuarios")
                        .HasForeignKey("id_rol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("DB.Rol", b =>
                {
                    b.Navigation("usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
