using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using EneePrueba.Api.Endpoints.Parametro;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Prueba.TipoTareas.EditarTipoTarea;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Endpoints.TipoTarea.EditarTipoTarea;

public static class Endpoint
{
    public static void EditarTipo(this IEndpointRouteBuilder app)
    {
        app.MapPut(
                "/{id}",
                async ([FromRoute] Guid id, ParametroRequest request, IDispatcher dispatcher) =>
                {
                    var command = new EditarTipoTareaCommand(id, request.Nombre);
                    Either<
                        Enee.Core.CQRS.Validation.OK,
                        List<Enee.Core.CQRS.Validation.MessageValidation>
                    > result = await dispatcher.Dispatch(command);
                    return result.ToResponse(new ParametroResponse() { Id = id });
                }
            )
            .Produces<ParametroResponse>()
            .WithSummary("Editar Tipo Tarea")
            .WithDescription("Permite editar una Tipo tarea y devuelve el identificador creado")
            .WithOpenApi();
    }
}
