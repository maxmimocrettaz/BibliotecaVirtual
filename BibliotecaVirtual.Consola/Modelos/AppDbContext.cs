using Microsoft.EntityFrameworkCore;


namespace BibliotecaVirtual.Consola.Modelos
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            var rutaProyecto = Path.GetFullPath(Path.Combine(rutaBase, @"..\..\..\"));
            var rutaBd = Path.Combine(rutaProyecto, "sqlite.db");

            optionsBuilder.UseSqlite($"Data Source={rutaBd}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prestamo>()
                .HasKey(x => new { x.LibroId, x.UsuarioId });

            modelBuilder.Entity<Prestamo>()
                .HasOne(x => x.Libro)
                .WithMany(x => x.Prestamos)
                .HasForeignKey(x => x.LibroId);

            modelBuilder.Entity<Prestamo>()
                .HasOne(x => x.Usuario)
                .WithMany(x => x.Prestamos)
                .HasForeignKey(x => x.UsuarioId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        // ---
        // PR -> puso en algun lado algo
        // agregado en desarrollo
    }
}
