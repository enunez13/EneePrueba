using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Endpoints.Parametro;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.EstadoTareas.CreateEstadoTarea;

namespace EneePrueba.Api.Endpoints.EstadoTarea.CrearEstadoTarea;

public static class Endpoint
{
    public static void CrearEstado(this IEndpointRouteBuilder app)
    {
        app.MapPost(
                "/",
                async (ParametroRequest request, IDispatcher dispatcher) =>
                {
                    var id = Guid.NewGuid();
                    var command = new EstadoTareaCommand(id, request.Nombre);
                    Either<
                        Enee.Core.CQRS.Validation.OK,
                        List<Enee.Core.CQRS.Validation.MessageValidation>
                    > result = await dispatcher.Dispatch(command);
                    return result.ToResponse(new ParametroResponse() { Id = id });
                }
            )
            .Produces<ParametroResponse>()
            .WithSummary("Crear Estado")
            .WithOpenApi();
    }
}
