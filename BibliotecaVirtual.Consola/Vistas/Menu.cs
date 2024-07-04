using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaVirtual.Consola.Vistas;

namespace BibliotecaVirtual.Consola.Vistas
{
   public class Menu
    {
        UsuarioVista vistaUsuario = new UsuarioVista();
          
            public void MostrarMenu()
            {
                int eleccion;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1- Ingrese un usuario");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("2- Obtener Todos los Usuarios");
                Console.WriteLine("3- Obtener usuario por Id");
                Console.WriteLine("4- Actualizar Usuario");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5- Eliminar Usuario");
                Console.ForegroundColor = ConsoleColor.White;


            eleccion = int.Parse(Console.ReadLine());

                switch (eleccion)
                {
                    case 1:
                        Console.WriteLine();
                        vistaUsuario.CargarUsuario();

                        Console.WriteLine();
                        MostrarMenu();

                    break;

                    case 2:
                        Console.WriteLine();
                        vistaUsuario.ObtenerUsuarios();
                        Console.WriteLine();
                        MostrarMenu();
                    break;
                    case 3:
                        Console.WriteLine();
                        vistaUsuario.ObtenerUsuarioPorId();
                        Console.WriteLine();
                        MostrarMenu();
                    break;

                    case 4:
                        Console.WriteLine();
                        vistaUsuario.ActualizarUsuario();
                        Console.WriteLine();
                        MostrarMenu();
                    break;
                    case 5:
                        Console.WriteLine();
                        vistaUsuario.EliminarUsuario();
                        Console.WriteLine();
                        MostrarMenu();
                    break;

                }    
            }
        }
    }
