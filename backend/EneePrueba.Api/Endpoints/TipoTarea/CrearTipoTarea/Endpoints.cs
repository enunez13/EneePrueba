using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.TipoTareas;
using EneePrueba.Domain.Prueba.TipoTareas.CrearTarea;

namespace EneePrueba.Api.Endpoints.Parametro.CrearTipoTarea;

public static class Endpoint
{
    public static void CrearTipo(this IEndpointRouteBuilder app)
    {
        app.MapPost(
                "/",
                async (ParametroRequest request, IDispatcher dispatcher) =>
                {
                    var id = Guid.NewGuid();
                    var command = new TipoTareaCommand(id, request.Nombre);
                    Either<
                        Enee.Core.CQRS.Validation.OK,
                        List<Enee.Core.CQRS.Validation.MessageValidation>
                    > result = await dispatcher.Dispatch(command);
                    return result.ToResponse(new ParametroResponse() { Id = id });
                }
            )
            .Produces<ParametroResponse>()
            .WithSummary("Crear Tipo")
            .WithOpenApi();
    }
}
