﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Controladores
{
    public class PrestamoController
    {
        public void CargarPrestamo(Prestamo p)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                context.Set<Prestamo>().Add(p);
                context.SaveChanges();
            }
        }

        public List<Prestamo> ListarPrestamos()
        {
            using (var context = new AppDbContext())
            {
                List<Prestamo> lista = context.Prestamos
                    .Include(x => x.Libro)
                    .Include(x => x.Lector)
                    .ToList();

                return lista;
            }

        }
    }
}