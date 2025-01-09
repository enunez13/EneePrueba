using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.Tareas.CrearTarea;
using static EneePrueba.Domain.Prueba.Tareas.TareaRoot;

namespace EneePrueba.Api.Endpoints.Tarea.CrearTarea;

public static class Endpoint
{
    public static void CrearTarea(this IEndpointRouteBuilder app)
    {
        app.MapPost(
                "/",
                async (TareaRequest request, IDispatcher dispatcher) =>
                {
                    var id = Guid.NewGuid();

                    var command = new CrearTareaCommand(
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
                    return result.ToResponse(new TareaResponse() { Id = id });
                }
            )
            .Produces<TareaResponse>()
            // .RequireAuthorization()
            .WithSummary("Crear Tarea")
            .WithDescription("Permite crear una Tarea y devuelve el identificador creado")
            .WithOpenApi();
    }
}
