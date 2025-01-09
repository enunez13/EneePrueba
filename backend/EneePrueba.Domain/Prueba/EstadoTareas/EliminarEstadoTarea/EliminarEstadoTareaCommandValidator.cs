using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.EstadoTareas.EliminarEstadoTarea;

public class EliminarEstadoTareaCommandValidator : CommandValidatorBase<EliminarEstadoTareaCommand>
{
    public EliminarEstadoTareaCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
    }
}
