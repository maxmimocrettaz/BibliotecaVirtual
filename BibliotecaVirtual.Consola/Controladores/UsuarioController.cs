using BibliotecaVirtual.Consola.Modelos;
using BibliotecaVirtual.Consola.Respositorios;
using BibliotecaVirtual.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Controladores
{
    class UsuarioController
    {
        public Usuario Guardar(Usuario usuario)
        {
            var repo = new RepositorioGenerico<Usuario>();

            repo.Crear(usuario);
           
            return usuario; 
        }

        public List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            var repo = new RepositorioGenerico<Usuario>();

            usuarios = repo.VerTodos();

            return usuarios;
        }


        public Usuario Modificar (Usuario usuario)
        {
            var repo = new RepositorioGenerico<Usuario>();
            repo.Actualizar(usuario);

            return usuario;
        }

        public Boolean ELiminar (Usuario usuario)
        {
            var repo = new RepositorioGenerico<Usuario>();
            repo.Eliminar(usuario);

            return true; 
        }

        public Usuario ObtenerUsuarioPorNombre (Usuario usuario)
        {
            var repo = new RepositorioUsuario();
            repo.ObtenerPorNombre(usuario.Nombre);

            return usuario;
        }
    }
}
