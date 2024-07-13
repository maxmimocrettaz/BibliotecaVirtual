using BibliotecaVirtual.Consola.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Validaciones
{
    public class LibroValidator : AbstractValidator<Libro>
    {
        public LibroValidator() 
        {
            RuleFor(x => x.Titulo).NotNull().NotEmpty();
            RuleFor(x => x.Autor).NotNull().NotEmpty();

        }
    }
}
