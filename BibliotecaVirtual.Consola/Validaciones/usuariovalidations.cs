using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVirtual.Consola.Validaciones
{
    public class usuariovalidations : AbstractValidator<usuariovalidations>
    {
      public usuariovalidations()
        {
            RuleFor(x =>x)
        }
    }
}
