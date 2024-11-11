using Microsoft.EntityFrameworkCore;

namespace DB
{
    /*
     * CONTEXTO DE LA BASE DE DATOS
     * Punto central o núcleo de la base de datos, aquí se definirá la estructura inicial
     */
    public class StyleSysContext : DbContext
    {
        /*
         * Sobreescribe el método "OnModelCreating" para crear las tablas con nombres personalizados
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se configura el nombre de las tablas
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Categoria>().ToTable("Categoria");
            modelBuilder.Entity<Proveedor>().ToTable("Proveedor");
            modelBuilder.Entity<Producto>().ToTable("Producto");
            modelBuilder.Entity<CompraCabecera>().ToTable("Compra");
            modelBuilder.Entity<CompraDetalle>().ToTable("CompraDetalle");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<FormaPago>().ToTable("FormaPago");
            modelBuilder.Entity<VentaCabecera>().ToTable("Venta");
            modelBuilder.Entity<VentaDetalle>().ToTable("VentaDetalle");

            //Constraints de UNIQUE
            modelBuilder.Entity<Usuario>()
                .HasAlternateKey(u => u.us_nickname)
                .HasName("UNQ_NICKNAME");

            modelBuilder.Entity<Usuario>()
                .HasAlternateKey(u => u.us_email)
                .HasName("UNQ_EMAIL");

            modelBuilder.Entity<Usuario>()
                .HasAlternateKey(u => u.us_dni)
                .HasName("UNQ_DNI");

            modelBuilder.Entity<Proveedor>()
                .HasAlternateKey(p => p.prov_cuit)
                .HasName("UNQ_CUIT");

            modelBuilder.Entity<CompraCabecera>()
                .HasAlternateKey(c => c.cod_cabecera)
                .HasName("UNQ_COD");
            
            modelBuilder.Entity<VentaCabecera>()
                .HasAlternateKey(v => v.cod_cabecera)
                .HasName("UNQ_COD_V");

            modelBuilder.Entity<Cliente>()
                .HasAlternateKey(c => c.cl_email)
                .HasName("UNQ_EMAILCliente");

            modelBuilder.Entity<Cliente>()
                .HasAlternateKey(c => c.cl_dni)
                .HasName("UNQ_DNIcliente");

            /**************** Inicia el data seeding (Datos iniciales en la base de datos) **********************/
            //Seeding de Roles
            modelBuilder.Entity<Rol>().HasData(
                new Rol
                {
                    id_rol = 1,
                    rol_nombre = "Empleado",
                    rol_descripcion = "Encargado principalmente de vender los artículos.",
                    rol_estado = true
                },
                new Rol
                {
                    id_rol = 2,
                    rol_nombre = "Administrador",
                    rol_descripcion = "Gestión de productos, usuarios, proveedores y reportes.",
                    rol_estado = true
                },
                new Rol
                {
                    id_rol = 3,
                    rol_nombre = "Super Administrador",
                    rol_descripcion = "Gestión de usuarios y permisos.",
                    rol_estado = true
                }
            );

            //Seeding de Usuarios
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    id_usuario = 1,
                    us_nombre = "Ciro",
                    us_apellido = "Solalinde",
                    us_dni = 43205377,
                    us_nickname = "admin",
                    us_direccion = "Calle Ficticia 123",
                    us_clave = "ac9689e2272427085e35b9d3e3e8bed88cb3434828b43b86fc0596cad4c6e270", //Clave Hasheada: admin1234
                    us_email = "admin@maill.com",
                    id_rol = 3,
                    us_estado = true,
                    us_fechaNacimiento = new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5385),
                    us_telefono = "3794143742"
                },
                new Usuario
                {
                    id_usuario = 2,
                    us_nombre = "Maximiliano",
                    us_apellido = "Luna",
                    us_dni = 41333654,
                    us_nickname = "mluna",
                    us_direccion = "Calle Ficticia 123",
                    us_clave = "ae571eafd64e7aed0e74610a624cb273ccb741334913730acc1717ef04e28857", //Clave Hasheada: mluna123
                    us_email = "mluna@maill.com",
                    id_rol = 2,
                    us_estado = true,
                    us_fechaNacimiento = new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5397),
                    us_telefono = "3794253368"
                },
                new Usuario
                {
                    id_usuario = 3,
                    us_nombre = "Lucas",
                    us_apellido = "Lopez",
                    us_dni = 32541569,
                    us_nickname = "llopez",
                    us_direccion = "Calle Ficticia 123",
                    us_clave = "37705012ac2afebf8b66739074b7b4401c48d9497e42bc588d176870fa738f70", //Clave Hasheada: llopez123
                    us_email = "llopez@maill.com",
                    id_rol = 1,
                    us_estado = true,
                    us_fechaNacimiento = new DateTime(2024, 10, 25, 12, 42, 44, 359, DateTimeKind.Local).AddTicks(5399),
                    us_telefono = "3795266551"
                }
            );

            //Seeding categorias
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    id_categoria = 1,
                    cat_nombre = "Buzos",
                    cat_descripcion = "Abrigos rusticos y frizados.",
                    cat_estado = true
                },
                new Categoria
                {
                    id_categoria = 2,
                    cat_nombre = "Remeras",
                    cat_descripcion = "Remeras unisex.",
                    cat_estado = true
                },
                new Categoria
                {
                    id_categoria = 3,
                    cat_nombre = "Pantalones",
                    cat_descripcion = "Jeans, joggins y pantalones.",
                    cat_estado = true
                }
            );

            //Seeding proveedores
            modelBuilder.Entity<Proveedor>().HasData(
                new Proveedor
                {
                    id_proveedor = 1,
                    prov_cuit = 27369665228,
                    prov_razonSocial = "Semillero textil S.A.",
                    prov_nombre = "Semillero",
                    prov_descripcion = "Talleristas, tejedores, bordadores y estampadores.",
                    prov_estado = true,
                    prov_telefono = "3794558866",
                    prov_direccion = "Brasil 865"
                }
            );

            //Seeding productos
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    id_producto = 3,
                    id_categoria = 3,
                    id_proveedor = 1,
                    pr_nombre = "Shorts adidas sharp 33",
                    pr_estado = true,
                    pr_precioCompra = 9560,
                    pr_precioVenta = 17110,
                    pr_stock = 0,
                    pr_stockMinimo = 2
                },
                new Producto
                {
                    id_producto = 4,
                    id_categoria = 2,
                    id_proveedor = 1,
                    pr_nombre = "Campera Nike urbana",
                    pr_estado = true,
                    pr_precioCompra = 20100,
                    pr_precioVenta = 37990,
                    pr_stock = 0,
                    pr_stockMinimo = 3
                }
            );

            modelBuilder.Entity<FormaPago>().HasData(
                new FormaPago
                {
                    id_formaPago = 1,
                    fp_nombre = "Efectivo",
                    fp_descripcion = "Billetes"
                },
                new FormaPago
                {
                    id_formaPago = 2,
                    fp_nombre = "Tarjeta de débito",
                    fp_descripcion = "Mastercard, Visa, Tarjetas de billeteras virtuales"
                },
                new FormaPago
                {
                    id_formaPago = 3,
                    fp_nombre = "Tarjeta de Crédito",
                    fp_descripcion = "La acreditación depende del banco"
                },
                new FormaPago
                {
                    id_formaPago = 4,
                    fp_nombre = "QR",
                    fp_descripcion = "Para billeteras virtuales (MP, MODO)"
                }
            );
        }
        /******************************** FIN SEEDING *****************************************/



        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<CompraCabecera> compraCabeceras { get; set; }
        public DbSet<CompraDetalle> compraDetalles { get; set; }
        public DbSet<FormaPago> formaPagos { get; set; }
        public  DbSet<Cliente> Clientes { get; set; }
        public DbSet<VentaCabecera> ventaCabeceras { get; set; }
        public DbSet<VentaDetalle> ventaDetalles { get; set; }

        /*
         * Configuración del Connection String para la base de datos 
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=.\\SQLEXPRESS;Database=StyleSysDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;ConnectRetryCount=0",
                    options => options.EnableRetryOnFailure());
        }

    }
}
