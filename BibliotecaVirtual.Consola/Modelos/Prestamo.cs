using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Prestamo : BaseEntidad
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int LibroId { get; set; }
        public Libro Libro { get; set; }

        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
