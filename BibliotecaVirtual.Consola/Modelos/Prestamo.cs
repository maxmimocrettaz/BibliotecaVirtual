using BibliotecaVirtual.Consola.Enumeraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Prestamo
    {
        public int UsuarioId { get; set; }       
        public Usuario Usuario { get; set; }

        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public EstadoPrestamoEnum Estado { get; set; }
        public DateTime FechaPrestamo { get; set; }

        public Prestamo()
        {
            Estado=EstadoPrestamoEnum.Iniciado;
        }

    }
}
