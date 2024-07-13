using BibliotecaVirtual.Consola.Modelos;
using BibliotecaVirtual.Consola.Respositorios;
using BibliotecaVirtual.Consola.Validaciones;
using BibliotecaVirtual.Repositorio;
using FluentValidation;
using FluentValidation.Results;
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
            var Validator = new UsuarioValidator();

            ValidationResult result = Validator.Validate(usuario);

            if (! result.IsValid)
            {
                foreach (var failure in result.Errors)
                { 
                    
                }
            }

            usuario.FechaCreacion = DateTime.Now;
            usuario.FechaModificacion = DateTime.Now;
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
            var Validator = new UsuarioValidator();

            ValidationResult result = Validator.Validate(usuario);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {

                }
            }
            usuario.FechaModificacion = DateTime.Now;

            repo.Actualizar(usuario);

            return usuario;
        }

        public bool ELiminar (Usuario usuario)
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
