using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Prueba.EstadoTareas.Projections;
using EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.EstadoTareas.CreateEstadoTarea;

public class EstadoTareaValidator : CommandValidatorBase<EstadoTareaCommand>
{
    public EstadoTareaValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().NotNull();
    }
}
