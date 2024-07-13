using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Consola.Modelos;


namespace BibliotecaVirtual.Consola.Controladores
{
    public class LibroController
    {
        public void RegistrarLibro(Libro libro)
        {    
                using (AppDbContext context = new AppDbContext())
                {
                    context.Database.EnsureCreated();
                    context.Libros.Add(libro);
                    context.SaveChanges();
                }
        }

        public void ActualizarLibro(string titulo)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var libros = context.Libros.FirstOrDefault(l => l.Titulo == titulo);
                if (libros != null)
                {
                    libros.EstaPrestado = true;

                    context.SaveChanges();   
                }
            }
        }

        public  List<Libro> ObtenerTodos()
        {
            List<Libro> libros;

            using (AppDbContext context = new AppDbContext())
            {
                context.Database.EnsureCreated();
                libros = context.Libros.ToList();
            }
            return libros;
        }

    }
}
