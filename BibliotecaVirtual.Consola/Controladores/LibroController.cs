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
        Repositorio repo = Repositorio.ObtenerInstancia();
        public void GuardarLibro(Libro l)
        {

            

            repo.libros.Add(l);





        }

        public  List<Libro> ObtenerLibros()
        {

            return repo.libros;
        
        
        }
        




       


    }
}
