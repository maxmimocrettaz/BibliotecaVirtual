using BibliotecaVirtual.Consola.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Respositorios
{
    public class RepositorioUsuario
    {
        public Usuario Obtener(string nombre)
        {
            Usuario u = new Usuario();

            using (AppDbContext context = new AppDbContext())
            {
                u = context.Set<Usuario>().Where(x => x.Nombre == nombre).First();
            }
            return u;
        }

    }
}
