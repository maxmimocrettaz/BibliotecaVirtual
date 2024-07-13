using BibliotecaVirtual.Consola.Controladores;
using BibliotecaVirtual.Consola.Modelos;


namespace BibliotecaVirtual.Consola.Vistas
{
    public class PrestamoVista
    {
        PrestamoController prestamoController = new PrestamoController();
        public void PrestarLibro()
        {
            Prestamo presta = new Prestamo();

            Console.Write("Libro nro: ");
            presta.LibroId = int.Parse(Console.ReadLine());
            Console.Write("Se asigna a: ");
            presta.UsuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            prestamoController.PrestarLibro(presta);
        }

        public void DevolverLibro()
        {
            Prestamo presta = new Prestamo();

            Console.Write("Libro nro: ");
            presta.LibroId = int.Parse(Console.ReadLine());
            Console.Write("Lo devuelve el usuario nro: ");
            presta.UsuarioId = int.Parse(Console.ReadLine());
            Console.WriteLine();

            prestamoController.DevolverLibro(presta);
        }

        public void VerPrestamosActivos()
        {

            var lista = prestamoController.ObtenerPrestamosActivos();
            
            if (item.Estado == Enumeraciones.EstadoPrestamoEnum.Iniciado)
            {
                foreach (var item in lista)
                {
                    Console.WriteLine($"El libro: {item.Libro.Titulo}, lo tiene: {item.Usuario.Nombre}.");
                }
                Console.WriteLine("-----------------");
            }
            

        }
    }
}
