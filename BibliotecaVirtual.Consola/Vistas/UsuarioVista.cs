using BibliotecaVirtual.Consola.Controladores;
using BibliotecaVirtual.Consola.Modelos;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class UsuarioVista
    {
        UsuarioController controladorUsuario = new UsuarioController();
        Usuario nuevoUsuario = new Usuario();

        public void RegistrarNuevoUsuario()
        {

            Console.Write("Nombre: ");
            nuevoUsuario.Nombre = Console.ReadLine();
            Console.Write("DNI: ");
            nuevoUsuario.DNI = Console.ReadLine();

            controladorUsuario.Guardar(nuevoUsuario);

        }

        public void MostrarTodosLosUsuarios()
        {
            List<Usuario>listaUsuarios = new List<Usuario>();
            Console.Write("Lista de usuarios:");
            listaUsuarios = controladorUsuario.ObtenerUsuarios();
            foreach (var usuario in listaUsuarios)
            {
                Console.Write("Nombre: " +  usuario.Nombre + " - " + "DNI: " + usuario.DNI);
            }

        }

        public void ModificarUsuario()
        {
            

            Console.Write("Nuevo Nombre:");
            nuevoUsuario.Nombre = Console.ReadLine();
            Console.Write("Nuevo dni:");
            nuevoUsuario.DNI = Console.ReadLine();

            controladorUsuario.Modificar(nuevoUsuario);

        }

        public void EliminarUsuario()
        {
            Usuario aeliminar = new Usuario();

            Console.Write("Ingrese nombre del usuario a eliminar:");
            nuevoUsuario.Nombre = Console.ReadLine();

            aeliminar = controladorUsuario.ObtenerUsuarioPorNombre(nuevoUsuario);

            controladorUsuario.ELiminar(aeliminar);
            
        }

        public void BuscarPorNombre()
        {
            Usuario buscado = new Usuario();
            Console.Write("Ingrese el nombre del usuario a buscar:");
            nuevoUsuario.Nombre = Console.ReadLine();

            buscado = controladorUsuario.ObtenerUsuarioPorNombre(nuevoUsuario);
            Console.WriteLine("Nombre" + buscado.Nombre + " - " + "DNI: " + buscado.DNI);
        }


    }
}