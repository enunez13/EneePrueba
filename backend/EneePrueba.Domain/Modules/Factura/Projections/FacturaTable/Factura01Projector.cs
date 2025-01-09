using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Modules.Factura.Features.CrearFactura;
using EneePrueba.Domain.Modules.Factura.Features.EditarFactura;
using EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;

namespace EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;

public class FacturaProjector : TableProjector<Facturas>
{
    public FacturaProjector()
    {
        Create<FacturaCreada>(
            (@event, tabla) =>
            {
                tabla.Id = @event.AggregateId;
                tabla.Numero = @event.Numero;
                tabla.FechaEmision = @event.FechaEmision;
                tabla.EstadoId = @event.EstadoId;
            }
        );

        Project<FacturaEditada>(
            (@event, tabla) =>
            {
                tabla.Numero = @event.Numero;
                tabla.FechaEmision = @event.FechaEmision;
                tabla.EstadoId = @event.EstadoId;
            }
        );

        SoftDeleted<FacturaEliminada>();
    }
}
