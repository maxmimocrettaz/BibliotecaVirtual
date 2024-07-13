using BibliotecaVirtual.Consola.Modelos;
using BibliotecaVirtual.Repositorio;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaVirtual.Consola.Controladores
{
    public class PrestamoController
    {
        public Prestamo PrestarLibro(Prestamo prestamo)
        {
            var repo = new RepositorioGenerico<Prestamo>();
            
            repo.Crear(prestamo);

            return prestamo;

        }

        public Prestamo DevolverLibro(Prestamo prestamo)
        {
            var repo = new RepositorioGenerico<Prestamo>();

            prestamo.EstadoPrestamoEnum.Finalizado;

            repo.Actualizar(prestamo);

            return prestamo;
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            var repo = new RepositorioPRestamo<Prestamo>();

            var lista = repo.VerTodos();

            return lista;
        }
    }
}
