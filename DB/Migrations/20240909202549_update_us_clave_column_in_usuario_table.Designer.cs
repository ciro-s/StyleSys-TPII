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
    [Migration("20240909202549_update_us_clave_column_in_usuario_table")]
    partial class update_us_clave_column_in_usuario_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.HasAlternateKey("us_email")
                        .HasName("UNQ_EMAIL");

                    b.HasAlternateKey("us_nickname")
                        .HasName("UNQ_NICKNAME");

                    b.HasIndex("id_rol");

                    b.ToTable("Usuario", (string)null);
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
