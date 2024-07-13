using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Consola.Controladores;
using BibliotecaVirtual.Consola.Modelos;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class LibroVista
    {
     private LibroController librosController = new LibroController();


        public void RegistrarLibro()
        {
            Libro libroNuevo = new Libro();

            Console.WriteLine("Autor:");

            libroNuevo.Autor = Console.ReadLine();

            Console.WriteLine("Titulo:");

            libroNuevo.Titulo = Console.ReadLine();

         librosController.RegistrarLibro(libroNuevo);
        }
        
        public void ActualizarLibro()
        {
            string Titulo;
          
            Console.Write("Titulo: ");
           Titulo = Console.ReadLine();
           
            librosController.ActualizarLibro(Titulo);
        }


        public void VerTodosLosLibros()
        {
            List<Libro> listadoLibros = librosController.ObtenerTodos();

            Console.WriteLine("Listado de Libros cargados");

            foreach (var item in listadoLibros)
            {
                Console.WriteLine($"Autor: {item.Autor} Titulo: {item.Titulo} Estado: {item.Estado} ");
            }
        }
    }
}

