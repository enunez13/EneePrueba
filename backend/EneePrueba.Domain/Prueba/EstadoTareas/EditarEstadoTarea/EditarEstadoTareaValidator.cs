using Enee.Core.CQRS.Validation;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.EstadoTareas.EditarEstadoTarea;

internal class EditarEstadoTareaValidator : CommandValidatorBase<EditarEstadoTareaCommand>
{
    public EditarEstadoTareaValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().NotNull();
    }
}
