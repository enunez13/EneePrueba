using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using EneePrueba.Api.Endpoints.Tarea.CrearTarea;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.TipoTareas.EliminarTipoTarea;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.TipoTarea.EliminarTipoTarea;

public static class Endpoint
{
    public static void EliminarTipo(this IEndpointRouteBuilder app)
    {
        app.MapDelete(
                "/{id}",
                static async ([FromRoute] Guid id, IDispatcher dispatcher) =>
                {
                    Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(
                        new EliminarTipoTareaCommand(id)
                    );

                    return result.ToResponse(new TareaResponse() { Id = id });
                }
            )
            .Produces<TareaResponse>()
            .WithSummary("Eliminar tipo")
            .WithDescription("Permite eliminar tipo")
            .WithOpenApi();
        // .Access();
    }
}
