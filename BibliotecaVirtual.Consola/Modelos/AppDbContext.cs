using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                .HasKey(x => new { x.LibroId, x.LectorId });

            modelBuilder.Entity<Prestamo>()
                .HasOne(x => x.Libro)
                .WithMany(x => x.Lectores)
                .HasForeignKey(x => x.LibroId);

            modelBuilder.Entity<Prestamo>()
                .HasOne(x => x.Lector)
                .WithMany(x => x.Libros)
                .HasForeignKey(x => x.LectorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Lector> Lectores { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        // ---
        // PR -> puso en algun lado algo
        // agregado en desarrollo
    }
}
