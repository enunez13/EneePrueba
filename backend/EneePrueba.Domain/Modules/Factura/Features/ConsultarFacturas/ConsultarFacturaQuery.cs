using EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;
using EneePrueba.Domain.Query;

namespace EneePrueba.Domain.Modules.Factura.Features.ConsultarFacturas;

public class ConsultarFacturaQuery : IPaginateQuery<FacturasFilters, Facturas>
{
    public ConsultarFacturaQuery(FacturasFilters filters)
    {
        Filters = filters;
    }

    public string Description { get; } = "Consultar Query";

    public FacturasFilters Filters { get; }
}
