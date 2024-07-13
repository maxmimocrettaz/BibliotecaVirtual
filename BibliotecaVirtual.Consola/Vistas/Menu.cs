using BibliotecaVirtual.Consola.Vistas;

namespace BibliotecaVirtual.Consola.Vistas
{
    public class Menu
    {

        UsuarioVista VistaUsuario = new UsuarioVista();
        PrestamoVista VistaPrestamo = new PrestamoVista();
        //LibroVista VistaLibro = new LibroVista();
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
            Console.WriteLine();
            int opcion;
            bool EsUnNumero;

            Console.Write("Opcion:");
            string Dato = Console.ReadLine();
            EsUnNumero = int.TryParse(Dato, out opcion);
            if (EsUnNumero)
            {
                int opcionM = opcion;

                switch (opcionM)
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
                        Console.Clear();
                        Console.WriteLine("Opcion Invalida");
                        Console.WriteLine();
                        MostrarMenu();
                        break;
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un numero");
                MostrarMenu();
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
            Console.WriteLine("|2) Modificar Usuarios       |");
            Console.WriteLine("|3) Lista de Usuarios        |");
            Console.WriteLine("|4) Buscar por Nombre        |");
            Console.WriteLine("|5) Menu Principal           |");
            Console.WriteLine("|6) Salir                    |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            int opcion;
            bool EsUnNumero;

            Console.Write("Opcion:");
            string Dato = Console.ReadLine();
            EsUnNumero = int.TryParse(Dato, out opcion);
            if (EsUnNumero)
            {
                int opcionU = opcion;

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
                        //VistaUsuario.ModificarUsuario();
                        Console.WriteLine();
                        MenuUsuario();
                        break;
                    case 3:
                        Console.Clear();
                        //VistaUsuario.MostrarTodosLosUsuarios();
                        Console.WriteLine();
                        MenuUsuario();
                        break;
                    case 4:
                        Console.Clear();
                        //VistaUsuario.BuscarPorNombre();
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
                        Console.WriteLine("Opcion Invalida");
                        Console.WriteLine();
                        MenuUsuario();
                        break;
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un numero");
                MenuUsuario();
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
            Console.WriteLine("|2) Devolver Libro           |");
            Console.WriteLine("|3) Ver Prestamos            |");
            Console.WriteLine("|4) Registrar Libro          |");
            Console.WriteLine("|5) Actualizar Libro         |");
            Console.WriteLine("|6) Lista de Libros          |");
            Console.WriteLine("|7) Menu Principal           |");
            Console.WriteLine("|8) Salir                    |");
            Console.WriteLine("|                            |");
            Console.WriteLine("|~~~~~~~~~~~~~~~~~~~~~~~~~~~~|");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            int opcion;
            bool EsUnNumero;

            Console.Write("Opcion:");
            string Dato = Console.ReadLine();
            EsUnNumero = int.TryParse(Dato, out opcion);
            if (EsUnNumero)
            {
                int opcionL = opcion;
                //int opcionL = int.Parse(Console.ReadLine());
                switch (opcionL)
                {
                    case 1:
                        Console.Clear();
                        //VistaPrestamo.PrestarLibro();
                        Console.WriteLine();
                        MenuLibro();
                        break;
                    case 2:
                        Console.Clear();
                        //VistaPrestamo.DevolverLibro();
                        Console.WriteLine();
                        MenuLibro();
                        break;
                    case 3:
                        Console.Clear();
                        //VistaPrestamo.VerPrestamosActivos();
                        Console.WriteLine();
                        MenuLibro();
                        break;
                    case 4:
                        Console.Clear();
                        //VistaLibro.ResgistrarLibro();
                        Console.WriteLine();
                        MenuLibro();
                        break;
                    case 5:
                        Console.Clear();
                        //VistaLibro.ActualizarLibro();
                        Console.WriteLine();
                        MenuLibro();
                        break;
                    case 6:
                        Console.Clear();
                        //VistaLibro.VerTodosLosLibros();
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
                        Console.WriteLine("Opcion Invalida");
                        Console.WriteLine();
                        MenuLibro();
                        break;
                }
            }
            else
            {
                Console.WriteLine("El dato ingresado no es un numero");
                MenuLibro();
            }
        }
    }
}
