using BibliotecaVirtual.Consola.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Validaciones
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
      public UsuarioValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().NotNull().WithMessage("Este parametro no puede estar vacio.");
        }
    }
}
