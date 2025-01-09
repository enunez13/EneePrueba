using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;

public class EliminarTipoTareaCommandValidator : CommandValidatorBase<EliminarTipoTareaCommand>
{
    public EliminarTipoTareaCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
    }
}
