using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Repositorio
    {

        public List<Libro> libros = new List<Libro>();

        private static Repositorio instancia;


       public static Repositorio ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Repositorio();
                return instancia;
            }
            else
            {
                return instancia;
            }
        }








        private Repositorio()
        {
            preCargarDatos();
        }

        private void preCargarDatos()
        {
            libros.Add(new Libro()
            {
                Id = 1,
                Autor = "Pepe Perez",
                Titulo = "La Epopeya de Pepe",
                Categoria = "Fantasia",
                Año = 1000,




            });


         












        }
    }
}
