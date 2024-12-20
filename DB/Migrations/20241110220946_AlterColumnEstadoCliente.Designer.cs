﻿// <auto-generated />
using System;
using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(StyleSysContext))]
    [Migration("20241110220946_AlterColumnEstadoCliente")]
    partial class AlterColumnEstadoCliente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("DB.Cliente", b =>
                {
                    b.Property<int>("id_cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_cliente"));

                    b.Property<string>("cl_apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cl_dni")
                        .HasColumnType("int");

                    b.Property<string>("cl_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("cl_estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("cl_fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("cl_fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("cl_nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cl_telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_cliente");

                    b.HasAlternateKey("cl_dni")
                        .HasName("UNQ_DNIcliente");

                    b.HasAlternateKey("cl_email")
                        .HasName("UNQ_EMAILCliente");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("DB.CompraCabecera", b =>
                {
                    b.Property<int>("id_cabecera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_cabecera"));

                    b.Property<long>("cod_cabecera")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_usuario")
                        .HasColumnType("int");

                    b.Property<float>("monto_total")
                        .HasColumnType("real");

                    b.HasKey("id_cabecera");

                    b.HasAlternateKey("cod_cabecera")
                        .HasName("UNQ_COD");

                    b.HasIndex("id_usuario");

                    b.ToTable("Compra", (string)null);
                });

            modelBuilder.Entity("DB.CompraDetalle", b =>
                {
                    b.Property<int>("id_detalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_detalle"));

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("id_cabecera")
                        .HasColumnType("int");

                    b.Property<int>("id_producto")
                        .HasColumnType("int");

                    b.Property<float>("precio_compra")
                        .HasColumnType("real");

                    b.HasKey("id_detalle");

                    b.HasIndex("id_cabecera");

                    b.HasIndex("id_producto");

                    b.ToTable("CompraDetalle", (string)null);
                });

            modelBuilder.Entity("DB.Producto", b =>
                {
                    b.Property<int>("id_producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_producto"));

                    b.Property<int>("id_categoria")
                        .HasColumnType("int");

                    b.Property<int>("id_proveedor")
                        .HasColumnType("int");

                    b.Property<bool>("pr_estado")
                        .HasColumnType("bit");

                    b.Property<string>("pr_nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<float>("pr_precioCompra")
                        .HasColumnType("real");

                    b.Property<float>("pr_precioVenta")
                        .HasColumnType("real");

                    b.Property<int>("pr_stock")
                        .HasColumnType("int");

                    b.Property<int>("pr_stockMinimo")
                        .HasColumnType("int");

                    b.HasKey("id_producto");

                    b.HasIndex("id_categoria");

                    b.HasIndex("id_proveedor");

                    b.ToTable("Producto", (string)null);

                    b.HasData(
                        new
                        {
                            id_producto = 3,
                            id_categoria = 3,
                            id_proveedor = 1,
                            pr_estado = true,
                            pr_nombre = "Shorts adidas sharp 33",
                            pr_precioCompra = 9560f,
                            pr_precioVenta = 17110f,
                            pr_stock = 0,
                            pr_stockMinimo = 2
                        },
                        new
                        {
                            id_producto = 4,
                            id_categoria = 2,
                            id_proveedor = 1,
                            pr_estado = true,
                            pr_nombre = "Campera Nike urbana",
                            pr_precioCompra = 20100f,
                            pr_precioVenta = 37990f,
                            pr_stock = 0,
                            pr_stockMinimo = 3
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

            modelBuilder.Entity("DB.CompraCabecera", b =>
                {
                    b.HasOne("DB.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("DB.CompraDetalle", b =>
                {
                    b.HasOne("DB.CompraCabecera", "cabecera")
                        .WithMany()
                        .HasForeignKey("id_cabecera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Producto", "producto")
                        .WithMany()
                        .HasForeignKey("id_producto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cabecera");

                    b.Navigation("producto");
                });

            modelBuilder.Entity("DB.Producto", b =>
                {
                    b.HasOne("DB.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("id_categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Proveedor", "proveedor")
                        .WithMany()
                        .HasForeignKey("id_proveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoria");

                    b.Navigation("proveedor");
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
