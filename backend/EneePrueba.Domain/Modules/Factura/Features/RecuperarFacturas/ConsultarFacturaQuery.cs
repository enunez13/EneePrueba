using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Modules.Factura.Features.ConsultarFacturas;
using EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;
using EneePrueba.Domain.Query;

namespace EneePrueba.Domain.Modules.Factura.Features.RecuperarFacturas;

public class RecuperarFacturaQuery : IQuery<Facturas?>
{
    public RecuperaFacturaFilter Filters { get; }

    public RecuperarFacturaQuery(RecuperaFacturaFilter filters)
    {
        Filters = filters;
    }

    public string Description { get; } = "Recuperar factura";
}
