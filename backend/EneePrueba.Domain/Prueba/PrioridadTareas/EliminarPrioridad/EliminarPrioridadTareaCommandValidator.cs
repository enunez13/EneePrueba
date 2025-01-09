using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.EliminarPrioridad;

public class EliminarPrioridadTareaCommandValidator
    : CommandValidatorBase<EliminarPrioridadTareaCommand>
{
    public EliminarPrioridadTareaCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
    }
}
