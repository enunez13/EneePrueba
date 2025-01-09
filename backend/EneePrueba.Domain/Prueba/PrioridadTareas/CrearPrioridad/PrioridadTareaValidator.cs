using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Prueba.PrioridadTareas.Projections;
using EneePrueba.Domain.Prueba.Tareas.CrearTarea;
using EneePrueba.Domain.Prueba.Tareas.Projections;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.CrearPrioridad;

internal class PrioridadTareaValidator : CommandValidatorBase<PrioridadTareaCommand>
{
    public PrioridadTareaValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().NotNull();
    }
}
