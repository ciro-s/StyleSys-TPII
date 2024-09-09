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

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

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
        }

        /*
         * Configuración del Connection String para la base de datos 
         */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(
                    "Server=CIROSOLALINDE\\SQLEXPRESS;Database=StyleSysDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;ConnectRetryCount=0",
                    options => options.EnableRetryOnFailure());
        }

    }
}
