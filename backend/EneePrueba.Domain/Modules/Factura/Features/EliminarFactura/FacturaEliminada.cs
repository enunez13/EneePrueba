using Enee.Core.Common;

namespace EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;

public class FacturaEliminada : DomainEvent<Guid>
{
    public FacturaEliminada(Guid aggregateId)
        : base(aggregateId) { }
}
