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
        LibroController controladorLibros = new LibroController();


        public void CargarDatosLibro()
        {
            Libro libroNuevo = new Libro();

            Console.WriteLine("Autor:");

            libroNuevo.Autor = Console.ReadLine();

            Console.WriteLine("Titulo:");

            libroNuevo.Titulo = Console.ReadLine();

            Console.WriteLine("Categoría:");

            libroNuevo.Categoria = Console.ReadLine();

            Console.WriteLine("Año:");

            libroNuevo.Año = int.Parse(Console.ReadLine());

          controladorLibros.GuardarLibro(libroNuevo);
            


        }
        
        public void MostrarLibros()
        {
            List<Libro> listadoLibros = controladorLibros.ObtenerLibros();

            Console.WriteLine("Listado de Libros cargados");

            foreach (var item in listadoLibros)
            {
                Console.WriteLine($">Autor: {item.Autor} -Titulo: {item.Titulo} -Categoria: {item.Categoria} -Año: {item.Año} ");
            }
        }






    }



}

