using Enee.Core.Domain;

namespace EneePrueba.Domain.Modules.Factura.Projections.FacturaTable;

public class DetalleFactura : EntityAuditable<Guid>
{
    public Guid FacturaId { get; set; }
    public string Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
}
