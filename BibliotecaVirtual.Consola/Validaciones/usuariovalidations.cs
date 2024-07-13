using BibliotecaVirtual.Consola.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Validaciones
{
    public class usuariovalidations : AbstractValidator<Usuario>
    {
      public usuariovalidations()
        {
            RuleFor(x => x.Nombre).NotEmpty().NotNull().WithMessage("Este parametro no puede estar vacio");
            RuleFor(x => x.Prestamos).NotEmpty();
        }
    }
}
