using BibliotecaVirtual.Consola.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Validaciones
{
    public class Prestamovalidators : AbstractValidator<Prestamo>
    {
        public Prestamovalidators() 
        {
            RuleFor(x => x.Libro).NotEmpty();
            RuleFor(x => x.Usuario).NotEmpty();
        }
    }
}
