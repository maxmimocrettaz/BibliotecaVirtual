using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Controladores
using System.Modelos

namespace BibliotecaVirtual.Consola.Vistas
{
    public class UsuarioVista
    {
        UsuarioController controladorUsuario = new UsuarioController();
         
        public void CargarUsuario()
        {
            Usuario nuevoUsuario = new Usuario();

            Console.Write("Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese DNI sin puntos ni espacios");
            Console.Write("DNI: ");
            usuario.DNI = Console.ReadLine();
            Console.Write("Ingrese Telefono (solo digitos)");
            Console.Write("Telefono: ");
            usuario.Telefono = Console.ReadLine();
            Console.Write("Email: ");
            usuario.Correo = Console.ReadLine();

            controladorUsuario.GuardarUsuario(nuevoUsuario)

        }

        public void MostrarListaUsuarios()
        {
            List<Usuario> listadoUsuarios = controladorUsuario.ObtenerUsuarios();

            Console.WriteLine("Listado de Usuarios registrados en el sistema");

            foreach (var item in listadoUsuarios)
            {
                Console.WriteLine($">Nombre: {item.Nombre} {item.Apellido} -DNI: {item.DNI} -Tel: {item.Telefono} -Email: {item.Correo}");
            }

        }

    }
}