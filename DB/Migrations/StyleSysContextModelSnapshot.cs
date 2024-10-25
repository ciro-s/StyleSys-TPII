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

            modelBuilder.Entity("DB.Categoria", b =>
                {
                    b.Property<int>("id_categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_categoria"));

                    b.Property<string>("cat_descripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("cat_estado")
                        .HasColumnType("bit");

                    b.Property<string>("cat_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id_categoria");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            id_categoria = 1,
                            cat_descripcion = "Abrigos rusticos y frizados.",
                            cat_estado = true,
                            cat_nombre = "Buzos"
                        },
                        new
                        {
                            id_categoria = 2,
                            cat_descripcion = "Remeras unisex.",
                            cat_estado = true,
                            cat_nombre = "Remeras"
                        },
                        new
                        {
                            id_categoria = 3,
                            cat_descripcion = "Jeans, joggins y pantalones.",
                            cat_estado = true,
                            cat_nombre = "Pantalones"
                        });
                });

            modelBuilder.Entity("DB.Proveedor", b =>
                {
                    b.Property<int>("id_proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_proveedor"));

                    b.Property<long>("prov_cuit")
                        .HasColumnType("bigint");

                    b.Property<string>("prov_descripcion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("prov_direccion")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("prov_estado")
                        .HasColumnType("bit");

                    b.Property<string>("prov_nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("prov_razonSocial")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("prov_telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("id_proveedor");

                    b.HasAlternateKey("prov_cuit")
                        .HasName("UNQ_CUIT");

                    b.ToTable("Proveedor", (string)null);

                    b.HasData(
                        new
                        {
                            id_proveedor = 1,
                            prov_cuit = 27369665228L,
                            prov_descripcion = "Talleristas, tejedores, bordadores y estampadores.",
                            prov_direccion = "Brasil 865",
                            prov_estado = true,
                            prov_nombre = "Semillero",
                            prov_razonSocial = "Semillero textil S.A.",
                            prov_telefono = "3794558866"
                        });
                });

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
                            rol_descripcion = "Gestión de productos, usuarios, proveedores y reportes.",
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
                        .HasColumnType("nvarchar(450)");

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
                            us_clave = "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270",
                            us_direccion = "Calle Ficticia 123",
                            us_dni = 43205377,
                            us_email = "admin@maill.com",
                            us_estado = true,
                            us_fechaNacimiento = new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5385),
                            us_nickname = "admin",
                            us_nombre = "Ciro",
                            us_telefono = "3794143742"
                        },
                        new
                        {
                            id_usuario = 2,
                            id_rol = 2,
                            us_apellido = "Luna",
                            us_clave = "ae571eafd64e7aed0e74610a624cb273ccb741334913730acc1717ef04e28857",
                            us_direccion = "Calle Ficticia 123",
                            us_dni = 41333654,
                            us_email = "mluna@maill.com",
                            us_estado = true,
                            us_fechaNacimiento = new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5397),
                            us_nickname = "mluna",
                            us_nombre = "Maximiliano",
                            us_telefono = "3794253368"
                        },
                        new
                        {
                            id_usuario = 3,
                            id_rol = 1,
                            us_apellido = "Lopez",
                            us_clave = "37705012ac2afebf8b66739074b7b4401c48d9497e42bc588d176870fa738f70",
                            us_direccion = "Calle Ficticia 123",
                            us_dni = 32541569,
                            us_email = "llopez@maill.com",
                            us_estado = true,
                            us_fechaNacimiento = new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5399),
                            us_nickname = "llopez",
                            us_nombre = "Lucas",
                            us_telefono = "3795266551"
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
