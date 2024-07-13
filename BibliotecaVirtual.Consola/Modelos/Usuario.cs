using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Modelos
{
    public class Usuario : BaseEntidad
    {
        [Required]
        public string Nombre {get; set;}
        [Required]
        public string DNI { get; set; }
        public List<Prestamo> Prestamos { get; set; }
        public Usuario(string nombre, string dni)
        {
            Nombre=nombre;
            DNI=dni;
        }
        public Usuario()
        {

        }
    }
}