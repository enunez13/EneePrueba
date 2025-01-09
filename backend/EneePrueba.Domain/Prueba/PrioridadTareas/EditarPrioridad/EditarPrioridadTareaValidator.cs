using Enee.Core.CQRS.Validation;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.PrioridadTareas.EditarPrioridad;

public class EditarPrioridadTareaValidator : CommandValidatorBase<EditarPrioridadTareaCommand>
{
    public EditarPrioridadTareaValidator()
    {
        RuleFor(x => x.Nombre).NotEmpty().NotNull();
    }
}
