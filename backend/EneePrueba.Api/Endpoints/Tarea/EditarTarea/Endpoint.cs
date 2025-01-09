using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.Tareas.EditarTareas;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.Tarea.EditarTarea;

public static class Endpoint
{
    public static void EditarTarea(this IEndpointRouteBuilder app)
    {
        app.MapPut(
                "/{id}",
                static async (
                    [FromRoute] Guid id,
                    EditarTareaRequest request,
                    IDispatcher dispatcher
                ) =>
                {
                    var command = new EditarTareaCommand(
                        id,
                        request.Nombre,
                        request.Descripcion,
                        request.FechaInicio,
                        request.FechaFin,
                        request.TipoTareaId,
                        request.EstadoId,
                        request.PrioridadId
                    );
                    Either<
                        Enee.Core.CQRS.Validation.OK,
                        List<Enee.Core.CQRS.Validation.MessageValidation>
                    > result = await dispatcher.Dispatch(command);
                    return result.ToResponse(new EditarTareaResponse() { Id = id });
                }
            )
            .Produces<EditarTareaResponse>()
            .WithSummary("Editar Tarea")
            .WithDescription("Permite editar una tarea y devuelve el identificador creado")
            .WithOpenApi();
    }
}
