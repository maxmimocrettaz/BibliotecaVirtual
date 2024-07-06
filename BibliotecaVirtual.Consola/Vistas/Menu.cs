using BibliotecaVirtual.Consola.Vistas;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class Menu
    {
        UsuarioVista VistaUsuario = new UsuarioVista();
        PrestamoVista VistaPrestamo = new PrestamoVista();
        public void MostrarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------Biblioteca Virtual------");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|                            |");
            Console.WriteLine("|1) Libros                   |"); 
            Console.WriteLine("|2) Usuarios                 |");
            Console.WriteLine("|3) Salir                    |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.ForegroundColor = ConsoleColor.Gray;
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    MenuLibro();
                    break;
                case 2:
                    Console.Clear();
                    MenuUsuario();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    MostrarMenu();
                    break;
            }
        }

        public void MenuUsuario()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------Biblioteca Virtual------");
            Console.WriteLine("|          USUARIOS          |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|                            |");
            Console.WriteLine("|1) Cargar Usuarios          |");
            Console.WriteLine("|2) Eliminar Usuarios        |");
            Console.WriteLine("|3) Lista de Usuarios        |");
            Console.WriteLine("|4) Buscar por Nombre        |");
            Console.WriteLine("|5) Menu Principal           |");
            Console.WriteLine("|6) Salir                    |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.ForegroundColor = ConsoleColor.Gray;

            int opcionU = int.Parse(Console.ReadLine());
            switch (opcionU)
            {
                case 1:
                    Console.Clear();
                    VistaUsuario.CargarUsuario();
                    Console.WriteLine();
                    MenuUsuario();
                    break;
                case 2:
                    Console.Clear();
                    //Eliminar Usuario
                    Console.WriteLine();
                    MenuUsuario();
                    break;
                case 3:
                    Console.Clear();
                    VistaUsuario.MostrarListaUsuarios();
                    Console.WriteLine();
                    MenuUsuario();
                    break;
                case 4:
                    Console.Clear();
                    // Buscar por Nombre
                    Console.WriteLine();
                    MenuUsuario();
                    break;
                case 5:
                    Console.Clear();
                    MostrarMenu();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    MenuUsuario();
                    break;
            }
        }

        public void MenuLibro()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------Biblioteca Virtual------");
            Console.WriteLine("|           LIBROS           |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.WriteLine("|                            |");
            Console.WriteLine("|1) Prestar Libro            |");
            Console.WriteLine("|2) Recibir Libro            |");
            Console.WriteLine("|3) Cargar Libro             |");
            Console.WriteLine("|4) Eliminar Libro           |");
            Console.WriteLine("|5) Lista de Libros          |");
            Console.WriteLine("|6) Buscar por Nombre        |");
            Console.WriteLine("|7) Menu Principal           |");
            Console.WriteLine("|8) Salir                    |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.ForegroundColor = ConsoleColor.Gray;

            int opcionL = int.Parse(Console.ReadLine());
            switch (opcionL)
            {
                case 1:
                    Console.Clear();
                    VistaPrestamo.Asignar();
                    Console.WriteLine();
                    MenuLibro();
                    break;
                case 2:
                    Console.Clear();
                    // Recibir libro
                    Console.WriteLine();
                    MenuLibro();
                    break;
                case 3:
                    Console.Clear();
                    // cargar libro
                    Console.WriteLine();
                    MenuLibro();
                    break;
                case 4:
                    Console.Clear();
                    //Eliminar libro
                    Console.WriteLine();
                    MenuLibro();
                    break;
                case 5:
                    Console.Clear();
                    VistaPrestamo.VerPrestamos();
                    Console.WriteLine();
                    MenuLibro();
                    break;
                case 6:
                    Console.Clear();
                    // Buscar por Nombre
                    Console.WriteLine();
                    MenuLibro();
                    break;
                case 7:
                    Console.Clear();
                    MostrarMenu();
                    break;
                case 8:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    MenuLibro();
                    break;
            }
        }
    }
}