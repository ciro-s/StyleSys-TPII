using Microsoft.EntityFrameworkCore;

namespace DB
{
    /*
     * CONTEXTO DE LA BASE DE DATOS
     * Punto central o núcleo de la base de datos, aquí se definirá la estructura inicial
     */
    public class StyleSysContext : DbContext
    {
        //Constructor de la clase
        //public StyleSysContext()
        //    : base("options") 
        //{
            
        //}

        /*
         * Sobreescribe el método "OnModelCreating" para crear las tablas con nombres personalizados
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se configura el nombre de las tablas
            modelBuilder.Entity<Rol>().ToTable("Rol");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");

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

            //Inicia el data seeding (Datos iniciales en la base de datos)
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
                    us_fechaNacimiento = DateTime.Now,
                    us_telefono = "3794143742"
                }
            );
        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

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
