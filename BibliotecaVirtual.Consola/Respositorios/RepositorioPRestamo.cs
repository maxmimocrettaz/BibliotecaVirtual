using BibliotecaVirtual.Consola.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Respositorios
{
    public class RepositorioPRestamo
    {
        public Prestamo Crear(Prestamo prestamo)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                context.Set<Prestamo>().Add(prestamo);
                context.SaveChanges();
            }
            return prestamo;
        }

        public Prestamo Actualizar(Prestamo prestamo)
        {

            using (AppDbContext context = new AppDbContext())
            {
                context.Set<Prestamo>().Update(prestamo);

                context.SaveChanges();
            }

            return prestamo;

        }

        public Prestamo Eliminar(Prestamo prestamo)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                context.Set<Prestamo>().Remove(prestamo);
                context.SaveChanges();
            }
            return prestamo;
        }

        public List<Prestamo> VerTodos()
        {
            List<Prestamo> listaPrestamos;

            using (AppDbContext context = new AppDbContext())
            {
                listaPrestamos = context.Set<Prestamo>()
                    .Include(x => x.Libro)
                    .Include(x => x.Usuario)
                    .ToList();
            }
            return listaPrestamos;
        }

    }
}
