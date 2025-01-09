using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using EneePrueba.Api.Endpoints.Tarea.CrearTarea;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.EstadoTareas.EliminarEstadoTarea;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.EstadoTarea.EliminarEstadoTarea;

public static class Endpoint
{
    public static void EliminarEstado(this IEndpointRouteBuilder app)
    {
        app.MapDelete(
                "/{id}",
                static async ([FromRoute] Guid id, IDispatcher dispatcher) =>
                {
                    Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(
                        new EliminarEstadoTareaCommand(id)
                    );

                    return result.ToResponse(new TareaResponse() { Id = id });
                }
            )
            .Produces<TareaResponse>()
            .WithSummary("Eliminar estado")
            .WithDescription("Permite eliminar estado")
            .WithOpenApi();
        // .Access();
    }
}
