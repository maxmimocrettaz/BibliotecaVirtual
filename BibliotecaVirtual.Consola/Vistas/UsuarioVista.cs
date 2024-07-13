using BibliotecaVirtual.Consola.Controladores;
using BibliotecaVirtual.Consola.Modelos;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class UsuarioVista
    {
        UsuarioController controladorUsuario = new UsuarioController();
        Usuario nuevoUsuario = new Usuario();

        public void CargarUsuario()
        {

            Console.Write("Nombre: ");
            nuevoUsuario.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            nuevoUsuario.Apellido = Console.ReadLine();
            Console.Write("Email: ");
            nuevoUsuario.Email = Console.ReadLine();

            controladorUsuario.NuevoUsuario(nuevoUsuario);

        }

        public void ObtenerUsuarios()
        {
            List<Usuario> listadousuarios = controladorUsuario.ObtenerUsuarios();

            Console.WriteLine("listado de usuarios registrados en el sistema");

            foreach (var item in listadousuarios)
            {
                Console.WriteLine($"<Nombre>: {item.Nombre}, <Apellido>: {item.Apellido}, <Email>: {item.Email}");
            }

        }

        public void ActualizarUsuario()
        {
            string email;
            string nombre;
            string apellido;
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();

            controladorUsuario.ActualizarUsuario(email, nombre, apellido);

        }

        public void EliminarUsuario()
        {
            string email;
            Console.Write("Email: ");
            email = Console.ReadLine();

            controladorUsuario.EliminarUsuario(email);
        }

        public void ObtenerUsuarioPorId()
        {
            int id;
            Usuario usuario;
            Console.Write("Ingrese Id: ");
            id = int.Parse(Console.ReadLine());


            usuario = controladorUsuario.ObtenerUsuarioPorId(id);

            Console.WriteLine($"<Nombre>: {usuario.Nombre}, <Apellido>: {usuario.Apellido}, <Email>: {usuario.Email}");
        }


    }
}