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
        [Required]  
        public bool EstaPrestado { get; set; }
        public List<Prestamo> Prestamos { get; set; } 
        public Libro(string titulo, string autor, List<Prestamo> usuario, bool estaPrestado)
        {
            Titulo=titulo;
            Autor=autor;
            Prestamos=usuario;
            EstaPrestado=estaPrestado;
        }

        public Libro() { }

    }
}
