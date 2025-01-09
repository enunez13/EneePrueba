using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enee.Core.CQRS.Validation;
using Enee.Core.Domain.Repository;
using EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;
using EneePrueba.Domain.Prueba.TipoTareas.Projections;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;

public class EditarTipoTareaValidator : CommandValidatorBase<EditarTipoTareaCommand>
{
    public EditarTipoTareaValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().NotNull();
    }
}
