using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using EneePrueba.Api.Endpoints.Tarea.CrearTarea;
using EneePrueba.Api.Modules.Factura.Features.CrearFacturas;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.Tareas.EliminarTarea;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.Tarea.EliminarTarea;

public static class Endpoint
{
    public static void EliminarTarea(this IEndpointRouteBuilder app)
    {
        app.MapDelete(
                "/{id}",
                static async ([FromRoute] Guid id, IDispatcher dispatcher) =>
                {
                    Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(
                        new EliminarTareaCommand(id)
                    );

                    return result.ToResponse(new TareaResponse() { Id = id });
                }
            )
            .Produces<TareaResponse>()
            .WithSummary("Eliminar Tarea")
            .WithDescription("Permite eliminar Tarea")
            .WithOpenApi();
        // .Access();
    }
}
