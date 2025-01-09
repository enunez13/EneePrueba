using Enee.Core.CQRS.Validation;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;
using FluentValidation;

namespace EneePrueba.Domain.Prueba.Tareas.EliminarTarea;

public class EliminarTareaCommandValidator : CommandValidatorBase<EliminarTareaCommand>
{
    public EliminarTareaCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
    }
}
