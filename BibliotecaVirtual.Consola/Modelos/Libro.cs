using BibliotecaVirtual.Consola.Enumeraciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Libro : BaseEntidad
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }
        public EstadoLibroEnum Estado { get; set; }
        public List<Prestamo> Prestamos { get; set; }
        public Libro()
        {
            Estado = EstadoLibroEnum.Disponible;
        }
    }
}
