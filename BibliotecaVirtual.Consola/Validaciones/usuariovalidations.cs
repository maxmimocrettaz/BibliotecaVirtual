using BibliotecaVirtual.Consola.Modelos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Validaciones
{
    public class Usuariovalotadtors : AbstractValidator<Usuario>
    {
      public Usuariovalotadtors()
        {
            RuleFor(x => x.Nombre).NotEmpty().NotNull().WithMessage("Este parametro no puede estar vacio");
        }
    }
}
