USE [master]
GO
/****** Object:  Database [StyleSysDB]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE DATABASE [StyleSysDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StyleSysDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\StyleSysDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StyleSysDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\StyleSysDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [StyleSysDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StyleSysDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StyleSysDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StyleSysDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StyleSysDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StyleSysDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StyleSysDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [StyleSysDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [StyleSysDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StyleSysDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StyleSysDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StyleSysDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StyleSysDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StyleSysDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StyleSysDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StyleSysDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StyleSysDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StyleSysDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StyleSysDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StyleSysDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StyleSysDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StyleSysDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StyleSysDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [StyleSysDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StyleSysDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StyleSysDB] SET  MULTI_USER 
GO
ALTER DATABASE [StyleSysDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StyleSysDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StyleSysDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StyleSysDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StyleSysDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StyleSysDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [StyleSysDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [StyleSysDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [StyleSysDB]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[cat_nombre] [nvarchar](20) NOT NULL,
	[cat_descripcion] [nvarchar](60) NOT NULL,
	[cat_estado] [bit] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[cl_nombre] [nvarchar](max) NOT NULL,
	[cl_apellido] [nvarchar](max) NOT NULL,
	[cl_dni] [int] NOT NULL,
	[cl_email] [nvarchar](450) NOT NULL,
	[cl_telefono] [nvarchar](max) NOT NULL,
	[cl_fechaNacimiento] [datetime2](7) NOT NULL,
	[cl_fechaAlta] [datetime2](7) NOT NULL,
	[cl_estado] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[id_cabecera] [int] IDENTITY(1,1) NOT NULL,
	[cod_cabecera] [bigint] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[monto_total] [real] NOT NULL,
	[fecha_registro] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[id_cabecera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_cabecera] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_compra] [real] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_CompraDetalle] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPago]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPago](
	[id_formaPago] [int] IDENTITY(1,1) NOT NULL,
	[fp_nombre] [nvarchar](30) NOT NULL,
	[fp_descripcion] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK_FormaPago] PRIMARY KEY CLUSTERED 
(
	[id_formaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[pr_estado] [bit] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[pr_nombre] [nvarchar](30) NOT NULL,
	[pr_precioCompra] [real] NOT NULL,
	[pr_precioVenta] [real] NOT NULL,
	[pr_stock] [int] NOT NULL,
	[pr_stockMinimo] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[prov_razonSocial] [nvarchar](40) NOT NULL,
	[prov_cuit] [bigint] NOT NULL,
	[prov_nombre] [nvarchar](20) NOT NULL,
	[prov_descripcion] [nvarchar](60) NOT NULL,
	[prov_telefono] [nvarchar](15) NOT NULL,
	[prov_direccion] [nvarchar](60) NOT NULL,
	[prov_estado] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [nvarchar](20) NOT NULL,
	[rol_descripcion] [nvarchar](60) NOT NULL,
	[rol_estado] [bit] NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[us_telefono] [nvarchar](max) NOT NULL,
	[id_rol] [int] NOT NULL,
	[us_apellido] [nvarchar](20) NOT NULL,
	[us_clave] [nvarchar](80) NOT NULL,
	[us_email] [nvarchar](450) NOT NULL,
	[us_estado] [bit] NOT NULL,
	[us_fechaNacimiento] [datetime2](7) NOT NULL,
	[us_nickname] [nvarchar](20) NOT NULL,
	[us_nombre] [nvarchar](20) NOT NULL,
	[us_direccion] [nvarchar](50) NOT NULL,
	[us_dni] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id_cabecera] [int] IDENTITY(1,1) NOT NULL,
	[cod_cabecera] [bigint] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_cliente] [int] NOT NULL,
	[id_formaPago] [int] NOT NULL,
	[monto_total] [real] NOT NULL,
	[fecha_registro] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id_cabecera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_cabecera] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[precio_venta] [real] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/13/2024 11:34:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([id_categoria], [cat_nombre], [cat_descripcion], [cat_estado]) VALUES (1, N'Buzos', N'Abrigos rusticos y frizados.', 1)
INSERT [dbo].[Categoria] ([id_categoria], [cat_nombre], [cat_descripcion], [cat_estado]) VALUES (2, N'Remeras', N'Remeras unisex.', 1)
INSERT [dbo].[Categoria] ([id_categoria], [cat_nombre], [cat_descripcion], [cat_estado]) VALUES (3, N'Pantalones', N'Jeans, joggins y pantalones.', 1)
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id_cliente], [cl_nombre], [cl_apellido], [cl_dni], [cl_email], [cl_telefono], [cl_fechaNacimiento], [cl_fechaAlta], [cl_estado]) VALUES (3, N'Maria', N'Gonzalez', 36554712, N'maria@mail.com', N'3794556221', CAST(N'2000-06-08T19:11:31.9250000' AS DateTime2), CAST(N'2024-11-10T19:12:12.7204035' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([id_cliente], [cl_nombre], [cl_apellido], [cl_dni], [cl_email], [cl_telefono], [cl_fechaNacimiento], [cl_fechaAlta], [cl_estado]) VALUES (4, N'juan', N'peres', 77777777, N'mail@mail.com', N'3794557789', CAST(N'2024-11-10T19:20:34.6681049' AS DateTime2), CAST(N'2024-11-10T19:20:53.3335600' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([id_cliente], [cl_nombre], [cl_apellido], [cl_dni], [cl_email], [cl_telefono], [cl_fechaNacimiento], [cl_fechaAlta], [cl_estado]) VALUES (5, N'Guillermo', N'Aquino', 36557412, N'aquino@mail.com', N'3794556893', CAST(N'1991-08-14T22:32:54.1470000' AS DateTime2), CAST(N'2024-11-10T22:33:54.0544673' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([id_cliente], [cl_nombre], [cl_apellido], [cl_dni], [cl_email], [cl_telefono], [cl_fechaNacimiento], [cl_fechaAlta], [cl_estado]) VALUES (6, N'Juana', N'Martinez', 45778612, N'juana@mail.com', N'3794150112', CAST(N'2024-11-10T22:35:29.4716873' AS DateTime2), CAST(N'2024-11-10T22:36:00.8595930' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([id_cliente], [cl_nombre], [cl_apellido], [cl_dni], [cl_email], [cl_telefono], [cl_fechaNacimiento], [cl_fechaAlta], [cl_estado]) VALUES (7, N'Nicolas', N'Meza', 39887500, N'nico@gmail.com', N'3794150023', CAST(N'2024-11-10T22:39:04.6808723' AS DateTime2), CAST(N'2024-11-10T22:39:34.2553778' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([id_cliente], [cl_nombre], [cl_apellido], [cl_dni], [cl_email], [cl_telefono], [cl_fechaNacimiento], [cl_fechaAlta], [cl_estado]) VALUES (8, N'Eliana', N'Lopez', 40125789, N'eliana@gmail.com', N'3794152368', CAST(N'2024-11-11T10:24:31.7465509' AS DateTime2), CAST(N'2024-11-11T10:25:04.8814533' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([id_cabecera], [cod_cabecera], [id_usuario], [monto_total], [fecha_registro]) VALUES (1, 63866920425157, 3, 67900, CAST(N'2024-11-11T11:13:45.1578021' AS DateTime2))
INSERT [dbo].[Compra] ([id_cabecera], [cod_cabecera], [id_usuario], [monto_total], [fecha_registro]) VALUES (2, 63866921527081, 3, 69860, CAST(N'2024-11-11T11:32:07.0814116' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[CompraDetalle] ON 

INSERT [dbo].[CompraDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_compra], [cantidad]) VALUES (1, 1, 4, 20100, 4)
INSERT [dbo].[CompraDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_compra], [cantidad]) VALUES (2, 1, 3, 9560, 5)
INSERT [dbo].[CompraDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_compra], [cantidad]) VALUES (3, 2, 4, 20100, 3)
INSERT [dbo].[CompraDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_compra], [cantidad]) VALUES (4, 2, 3, 9560, 1)
SET IDENTITY_INSERT [dbo].[CompraDetalle] OFF
GO
SET IDENTITY_INSERT [dbo].[FormaPago] ON 

INSERT [dbo].[FormaPago] ([id_formaPago], [fp_nombre], [fp_descripcion]) VALUES (1, N'Efectivo', N'Billetes')
INSERT [dbo].[FormaPago] ([id_formaPago], [fp_nombre], [fp_descripcion]) VALUES (2, N'Tarjeta de débito', N'Mastercard, Visa, Tarjetas de billeteras virtuales')
INSERT [dbo].[FormaPago] ([id_formaPago], [fp_nombre], [fp_descripcion]) VALUES (3, N'Tarjeta de Crédito', N'La acreditación depende del banco')
INSERT [dbo].[FormaPago] ([id_formaPago], [fp_nombre], [fp_descripcion]) VALUES (4, N'QR', N'Para billeteras virtuales (MP, MODO)')
SET IDENTITY_INSERT [dbo].[FormaPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id_producto], [id_categoria], [pr_estado], [id_proveedor], [pr_nombre], [pr_precioCompra], [pr_precioVenta], [pr_stock], [pr_stockMinimo]) VALUES (3, 3, 1, 1, N'Shorts adidas sharp 33', 9560, 17110, 6, 2)
INSERT [dbo].[Producto] ([id_producto], [id_categoria], [pr_estado], [id_proveedor], [pr_nombre], [pr_precioCompra], [pr_precioVenta], [pr_stock], [pr_stockMinimo]) VALUES (4, 2, 1, 1, N'Campera Nike urbana', 20100, 37990, 6, 3)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [prov_razonSocial], [prov_cuit], [prov_nombre], [prov_descripcion], [prov_telefono], [prov_direccion], [prov_estado]) VALUES (1, N'Semillero textil S.A.', 27369665228, N'Semillero', N'Talleristas, tejedores, bordadores y estampadores.', N'3794558866', N'Brasil 865', 1)
INSERT [dbo].[Proveedor] ([id_proveedor], [prov_razonSocial], [prov_cuit], [prov_nombre], [prov_descripcion], [prov_telefono], [prov_direccion], [prov_estado]) VALUES (2, N'proveedor de prrrueba', 2755411222, N'nuevo', N'prueba', N'3794920822', N'otra direccion 123', 1)
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([id_rol], [rol_nombre], [rol_descripcion], [rol_estado]) VALUES (1, N'Empleado', N'Encargado principalmente de vender los artículos.', 1)
INSERT [dbo].[Rol] ([id_rol], [rol_nombre], [rol_descripcion], [rol_estado]) VALUES (2, N'Administrador', N'Gestión de productos, usuarios, proveedores y reportes.', 1)
INSERT [dbo].[Rol] ([id_rol], [rol_nombre], [rol_descripcion], [rol_estado]) VALUES (3, N'Super Administrador', N'Gestión de usuarios y permisos.', 1)
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (1, N'3794143742', 3, N'Solalinde', N'ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270', N'admin@maill.com', 1, CAST(N'2024-10-28T18:04:02.0595444' AS DateTime2), N'admin', N'Ciro', N'Calle Ficticia 123', 43205377)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (2, N'3794253368', 2, N'Luna', N'ae571eafd64e7aed0e74610a624cb273ccb741334913730acc1717ef04e28857', N'mluna@maill.com', 1, CAST(N'2024-10-25T12:42:44.3595397' AS DateTime2), N'mluna', N'Maximiliano', N'Calle Ficticia 123', 41333654)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (3, N'3795266551', 1, N'Lopez', N'37705012ac2afebf8b66739074b7b4401c48d9497e42bc588d176870fa738f70', N'llopez@maill.com', 1, CAST(N'2024-10-25T12:42:44.3595399' AS DateTime2), N'llopez', N'Lucas', N'Calle Ficticia 123', 32541569)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (5, N'3795321125', 1, N'perez', N'contra123', N'juan@mail.com', 1, CAST(N'2024-09-18T11:32:40.4903521' AS DateTime2), N'jperez', N'juan', N'calle 123', 40212355)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (6, N'3975664412', 1, N'diaz', N'43e1d87870b90ffc872f1e90e08ef74c12c96c79482581938f18ca19ef5f10d8', N'diaz@mail.com', 1, CAST(N'2000-08-01T12:17:39.5420000' AS DateTime2), N'cdiaz', N'juan', N'direccion prueba', 23656989)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (7, N'3795221536', 3, N'usuario', N'password5', N'unmail@mail.com', 0, CAST(N'2024-09-18T12:36:21.8405214' AS DateTime2), N'nuser', N'nuevo', N'una calle', 25365777)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (8, N'3794552266', 2, N'Gonzalez', N'clave2', N'otromail@mail.com', 1, CAST(N'2024-09-18T17:07:38.6267547' AS DateTime2), N'jgonzalez', N'Juan', N'una calle 123', 23555677)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (9, N'3795223568', 1, N'Gimenez', N'ae091500677f29a97c5a355f205f58e8784ada26a70ce570f575eb574c734ee1', N'lucas@gmail.com', 0, CAST(N'2024-09-19T09:01:06.1780571' AS DateTime2), N'lgimenez', N'Lucas', N'direccion ficticia', 32575963)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (10, N'3794556688', 1, N'nuevo', N'9049b3693275c6ccfe89e95ed9755890729528796e661b5ad9f4db7aa8172f58', N'admin@mail.com', 0, CAST(N'2024-09-23T11:04:01.4529047' AS DateTime2), N'user', N'prueba', N'direccion', 43205378)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (11, N'3794556677', 1, N'lopez', N'd57bf68ca31dbf8625f29df04ec8bf5f83cc91c232a6b2d1c99b18dc186f6633', N'prueba@mail', 1, CAST(N'2024-09-30T08:05:03.6083104' AS DateTime2), N'PRUEBAUS3R', N'juan', N'98787', 25447889)
INSERT [dbo].[Usuario] ([id_usuario], [us_telefono], [id_rol], [us_apellido], [us_clave], [us_email], [us_estado], [us_fechaNacimiento], [us_nickname], [us_nombre], [us_direccion], [us_dni]) VALUES (12, N'3794558877', 1, N'prueba', N'cdcb7422ca0fe077931b84e6fb7e6dfb7d6678dc7e9ae9c4335e98edc7d5761a', N'prueba@mail.com', 1, CAST(N'2024-09-30T18:17:18.5502694' AS DateTime2), N'unaprueba', N'una', N'calle 123', 43244777)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (1, 63866873240911, 3, 3, 3, 75980, CAST(N'2024-11-10T22:07:20.9114092' AS DateTime2))
INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (5, 63866873553775, 3, 3, 1, 17110, CAST(N'2024-11-10T22:12:33.7757875' AS DateTime2))
INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (6, 63866873698068, 3, 3, 2, 37990, CAST(N'2024-11-10T22:14:58.0692481' AS DateTime2))
INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (7, 63866874073234, 3, 3, 1, 37990, CAST(N'2024-11-10T22:21:13.2347038' AS DateTime2))
INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (8, 63866917560960, 3, 8, 2, 17110, CAST(N'2024-11-11T10:26:00.9613422' AS DateTime2))
INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (9, 63866917751041, 3, 5, 3, 148190, CAST(N'2024-11-11T10:29:11.0420163' AS DateTime2))
INSERT [dbo].[Venta] ([id_cabecera], [cod_cabecera], [id_usuario], [id_cliente], [id_formaPago], [monto_total], [fecha_registro]) VALUES (10, 63866920493383, 3, 6, 3, 37990, CAST(N'2024-11-11T11:14:53.3837734' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
SET IDENTITY_INSERT [dbo].[VentaDetalle] ON 

INSERT [dbo].[VentaDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_venta], [cantidad]) VALUES (5, 7, 4, 37990, 1)
INSERT [dbo].[VentaDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_venta], [cantidad]) VALUES (6, 8, 3, 17110, 1)
INSERT [dbo].[VentaDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_venta], [cantidad]) VALUES (7, 9, 3, 17110, 2)
INSERT [dbo].[VentaDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_venta], [cantidad]) VALUES (8, 9, 4, 37990, 3)
INSERT [dbo].[VentaDetalle] ([id_detalle], [id_cabecera], [id_producto], [precio_venta], [cantidad]) VALUES (9, 10, 4, 37990, 1)
SET IDENTITY_INSERT [dbo].[VentaDetalle] OFF
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240906155126_InitDB', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240909143524_AddColumnsToUsuarios', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240909202549_update_us_clave_column_in_usuario_table', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240917110400_AddDniYDireccionToUsuario', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240917111517_SeedingRolTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240917112516_SeedingUsuario', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240927142615_UpdateUsuarioSeeding', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241025154244_CreateCategoriaProveedorTables', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241025213641_SeedingCategoriaYProveedor', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241028161654_CreateProductoTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241028210402_CreateClienteTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241031165203_NuevasColumnasTablaProducto', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241108165337_CreateComprasTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241108171840_CreateCompraDetalleTable', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241110220946_AlterColumnEstadoCliente', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241110233123_CreateFormaPagoVentasCabeceraYDetallesTables', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20241111011841_CorreccionVentaDetalle', N'8.0.8')
GO
/****** Object:  Index [UNQ_DNIcliente]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UNQ_DNIcliente] UNIQUE NONCLUSTERED 
(
	[cl_dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_EMAILCliente]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Cliente] ADD  CONSTRAINT [UNQ_EMAILCliente] UNIQUE NONCLUSTERED 
(
	[cl_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UNQ_COD]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Compra] ADD  CONSTRAINT [UNQ_COD] UNIQUE NONCLUSTERED 
(
	[cod_cabecera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Compra_id_usuario]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Compra_id_usuario] ON [dbo].[Compra]
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CompraDetalle_id_cabecera]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_CompraDetalle_id_cabecera] ON [dbo].[CompraDetalle]
(
	[id_cabecera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CompraDetalle_id_producto]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_CompraDetalle_id_producto] ON [dbo].[CompraDetalle]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_id_categoria]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Producto_id_categoria] ON [dbo].[Producto]
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_id_proveedor]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Producto_id_proveedor] ON [dbo].[Producto]
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UNQ_CUIT]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Proveedor] ADD  CONSTRAINT [UNQ_CUIT] UNIQUE NONCLUSTERED 
(
	[prov_cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UNQ_DNI]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UNQ_DNI] UNIQUE NONCLUSTERED 
(
	[us_dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_EMAIL]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UNQ_EMAIL] UNIQUE NONCLUSTERED 
(
	[us_email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UNQ_NICKNAME]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [UNQ_NICKNAME] UNIQUE NONCLUSTERED 
(
	[us_nickname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Usuario_id_rol]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Usuario_id_rol] ON [dbo].[Usuario]
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UNQ_COD_V]    Script Date: 11/13/2024 11:34:22 AM ******/
ALTER TABLE [dbo].[Venta] ADD  CONSTRAINT [UNQ_COD_V] UNIQUE NONCLUSTERED 
(
	[cod_cabecera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_id_cliente]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Venta_id_cliente] ON [dbo].[Venta]
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_id_formaPago]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Venta_id_formaPago] ON [dbo].[Venta]
(
	[id_formaPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_id_usuario]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_Venta_id_usuario] ON [dbo].[Venta]
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VentaDetalle_id_cabecera]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_VentaDetalle_id_cabecera] ON [dbo].[VentaDetalle]
(
	[id_cabecera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_VentaDetalle_id_producto]    Script Date: 11/13/2024 11:34:22 AM ******/
CREATE NONCLUSTERED INDEX [IX_VentaDetalle_id_producto] ON [dbo].[VentaDetalle]
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [id_proveedor]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (N'') FOR [pr_nombre]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (CONVERT([real],(0))) FOR [pr_precioCompra]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (CONVERT([real],(0))) FOR [pr_precioVenta]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [pr_stock]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [pr_stockMinimo]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (N'') FOR [us_apellido]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (CONVERT([bit],(0))) FOR [us_estado]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [us_fechaNacimiento]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (N'') FOR [us_nickname]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (N'') FOR [us_nombre]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT (N'') FOR [us_direccion]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((0)) FOR [us_dni]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Usuario_id_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Usuario_id_usuario]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Compra_id_cabecera] FOREIGN KEY([id_cabecera])
REFERENCES [dbo].[Compra] ([id_cabecera])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Compra_id_cabecera]
GO
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CompraDetalle_Producto_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK_CompraDetalle_Producto_id_producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria_id_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria_id_categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedor_id_proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedor_id_proveedor]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_id_rol] FOREIGN KEY([id_rol])
REFERENCES [dbo].[Rol] ([id_rol])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol_id_rol]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente_id_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id_cliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente_id_cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_FormaPago_id_formaPago] FOREIGN KEY([id_formaPago])
REFERENCES [dbo].[FormaPago] ([id_formaPago])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_FormaPago_id_formaPago]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Usuario_id_usuario] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuario] ([id_usuario])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Usuario_id_usuario]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Producto_id_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Producto_id_producto]
GO
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Venta_id_cabecera] FOREIGN KEY([id_cabecera])
REFERENCES [dbo].[Venta] ([id_cabecera])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Venta_id_cabecera]
GO
USE [master]
GO
ALTER DATABASE [StyleSysDB] SET  READ_WRITE 
GO
