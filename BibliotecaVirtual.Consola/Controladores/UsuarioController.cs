using BibliotecaVirtual.Consola.Modelos;
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
        public void NuevoUsuario(Usuario usuario)
        {
            try
            {
                using (AppDbContext context = new AppDbContext())
                {
                    context.Database.EnsureCreated();
                    context.Usuarios.Add(usuario);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error {e.Message}");
                if (e.InnerException != null)
                {
                    Console.WriteLine($"Excepción interna: {e.InnerException.Message}");
                }
            }
            
        }

        public List<Usuario> ObtenerUsuarios ()
        {
            List<Usuario> usuarios;
            
            using (AppDbContext context = new AppDbContext())
            {
                    context.Database.EnsureCreated();
                    usuarios = context.Usuarios.ToList();

            }
            return usuarios;
        }


        public void ActualizarUsuario (string email, string nuevoNombre, string nuevoCorreo)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Email == email);
                if(usuario != null)
                {
                    usuario.Nombre = nuevoNombre;
                    usuario.Email = nuevoCorreo;

                    context.SaveChanges();
                    Console.WriteLine("Usuario actualizado correctamente.");
                }else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
        }

        public void EliminarUsuario (string email)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Email == email);
                if(usuario != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                    Console.WriteLine("Usuario eliminado correctamente");
                }else
                {
                    Console.WriteLine("Usuario no encontrado.");
                }
            }
        }

        public Usuario ObtenerUsuarioPorId (int id)
        {
            Usuario usuario;
            using (AppDbContext context = new AppDbContext())
            {
                 usuario = context.Usuarios.Where(x => x.Id == id)
                    .First();
            }
            if(usuario == null)
            {
                Console.WriteLine("Usuario no encontrado");
                return null;
            }
            return usuario;
        }
    }
}
