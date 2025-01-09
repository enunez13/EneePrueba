using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Prueba.Tareas.Projections;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.Tareas.CrearTarea
{
    public class CrearTareaValidator : CommandValidatorBase<CrearTareaCommand>
    {
        public CrearTareaValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().NotNull();
            RuleFor(x => x.Descripcion).NotEmpty().NotNull();
            RuleFor(x => x.EstadoId).NotEmpty().NotNull();
            RuleFor(x => x.FechaInicio).NotEmpty().NotNull();
            RuleFor(x => x.FechaFin).NotEmpty().NotNull();
            RuleFor(x => x.TipoTareaId).NotEmpty().NotNull();
            RuleFor(x => x.PrioridadId).NotEmpty().NotNull();
        }
    }
}
