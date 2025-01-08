using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;

namespace EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;

public class EliminarFacturaCommandHandler(
    IWritableEventStoreRepository<Aggregates.Factura> facturas
) : ICommandHandler<EliminarFacturaCommand>
{
    public async Task Handle(EliminarFacturaCommand command)
    {
        Aggregates.Factura? factura = await facturas.Find(command.Id);
        factura.Eliminar();
        await facturas.Update(factura);
    }
}
