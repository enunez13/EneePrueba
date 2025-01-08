using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using EneePrueba.Api.Modules.Factura.Common;
using EneePrueba.Api.Utilities.Response;
using EneePrueba.Domain.Modules.Factura.Features.CrearFactura;

namespace EneePrueba.Api.Modules.Factura.Features.CrearFacturas;

public static class Endpoint
{
    public static void CrearFactura(this IEndpointRouteBuilder app)
    {
        app.MapPost(
                "/",
                async (FacturaRequest request, IDispatcher dispatcher) =>
                {
                    var id = Guid.NewGuid();
                    Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(
                        new CrearFacturaCommand(
                            id,
                            request.Numero,
                            request.FechaEmision,
                            request.EstadoId
                        )
                    );
                    return result.ToResponse(new FacturaResponse() { Id = id });
                }
            )
            .Produces<FacturaResponse>()
            .WithSummary("Crear factura")
            .WithDescription("Permite crear factura")
            .WithOpenApi();
        // .Access();
    }
}
