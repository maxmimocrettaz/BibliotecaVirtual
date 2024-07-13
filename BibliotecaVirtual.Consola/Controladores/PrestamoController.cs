using BibliotecaVirtual.Consola.Modelos;
using BibliotecaVirtual.Consola.Respositorios;
using BibliotecaVirtual.Consola.Enumeraciones;
using BibliotecaVirtual.Consola.Validaciones;
using FluentValidation.Results;
using BibliotecaVirtual.Consola.Validaciones;

namespace BibliotecaVirtual.Consola.Controladores
{
    public class PrestamoController
    {
        public Prestamo PrestarLibro(Prestamo prestamo)
        {
            var repo = new RepositorioPRestamo();
            var Validator = new PrestamoValidator();

            ValidationResult result = Validator.Validate(prestamo);

            if (!result.IsValid)
            {
                foreach (var failure in result.Errors)
                {

                }

            }

            repo.Crear(prestamo);

            return prestamo;

        }

        public Prestamo DevolverLibro(Prestamo prestamo)
        {
            var repo = new RepositorioPRestamo();

            prestamo.Estado = EstadoPrestamoEnum.Finalizado;

            repo.Actualizar(prestamo);

            return prestamo;
        }

        public List<Prestamo> ObtenerPrestamosActivos()
        {
            var repo = new RepositorioPRestamo();

            var lista = repo.VerTodos();

            return lista;
        }
    }
}
