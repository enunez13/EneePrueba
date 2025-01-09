using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Endpoints.Parametro;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.PrioridadTareas.CrearPrioridad;

namespace EneePrueba.Api.Endpoints.PrioridadTarea.CrearPrioridadTarea;

public static class Endpoint
{
    public static void CrearPrioridad(this IEndpointRouteBuilder app)
    {
        app.MapPost(
                "/",
                async (ParametroRequest request, IDispatcher dispatcher) =>
                {
                    var id = Guid.NewGuid();
                    var command = new PrioridadTareaCommand(id, request.Nombre);
                    Either<
                        Enee.Core.CQRS.Validation.OK,
                        List<Enee.Core.CQRS.Validation.MessageValidation>
                    > result = await dispatcher.Dispatch(command);
                    return result.ToResponse(new ParametroResponse() { Id = id });
                }
            )
            .Produces<ParametroResponse>()
            .WithSummary("Crear Prioridad")
            .WithOpenApi();
    }
}
