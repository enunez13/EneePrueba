using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Endpoints.Parametro;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.PrioridadTareas.EditarPrioridad;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.PrioridadTarea.EditarPrioridadTarea;

public static class Endpoint
{
    public static void EditarPrioridad(this IEndpointRouteBuilder app)
    {
        app.MapPut(
                "/{id}",
                async ([FromRoute] Guid id, ParametroRequest request, IDispatcher dispatcher) =>
                {
                    var command = new EditarPrioridadTareaCommand(id, request.Nombre);
                    Either<
                        Enee.Core.CQRS.Validation.OK,
                        List<Enee.Core.CQRS.Validation.MessageValidation>
                    > result = await dispatcher.Dispatch(command);
                    return result.ToResponse(new ParametroResponse() { Id = id });
                }
            )
            .Produces<ParametroResponse>()
            .WithSummary("Editar prioridad ")
            .WithDescription("Permite editar una prieridad y devuelve el identificador creado")
            .WithOpenApi();
    }
}
