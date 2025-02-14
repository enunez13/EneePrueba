using Enee.Core.Domain;

namespace EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;

public class Facturas : EntityAuditable<Guid>
{
    public string Numero { get; set; }
    public DateOnly FechaEmision { get; set; }
    public string EstadoId { get; set; }
}
