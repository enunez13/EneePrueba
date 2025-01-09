using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using EneePrueba.Api.Modules.Factura.Features.CrearFacturas;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;
using Microsoft.AspNetCore.Mvc;

namespace EneePrueba.Api.Modules.Factura.Features.EliminarFactura;

public static class Endpoint
{
    public static void EliminarFactura(this IEndpointRouteBuilder app)
    {
        app.MapDelete(
                "/{id}",
                async ([FromRoute] Guid id, IDispatcher dispatcher) =>
                {
                    Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(
                        new EliminarFacturaCommand(id)
                    );

                    return result.ToResponse(new FacturaResponse() { Id = id });
                }
            )
            .Produces<FacturaResponse>()
            .WithSummary("Eliminar factura")
            .WithDescription("Permite eliminar factura")
            .WithOpenApi();
        // .Access();
    }
}
