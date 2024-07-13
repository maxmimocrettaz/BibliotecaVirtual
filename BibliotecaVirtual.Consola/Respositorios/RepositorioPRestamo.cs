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
