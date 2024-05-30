using Microsoft.EntityFrameworkCore;

namespace BE_CRUDLibros.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        : base(options) 
        {
        }
        public DbSet<Libro> Libro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar la clave primaria para la entidad Libro
            modelBuilder.Entity<Libro>()
                .HasKey(l => l.isbn);

            // Configurar otras propiedades si es necesario
            modelBuilder.Entity<Libro>()
                .Property(l => l.isbn)
                .IsRequired();

            // Configurar otras entidades...
        }
    }
}
