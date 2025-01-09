using Enee.Core.CQRS.Query;
using EneePrueba.Domain.Modules.Almacen.Features.CrearAlmacen;
using EneePrueba.Domain.Modules.Almacen.Features.EliminarAlmacen;

namespace EneePrueba.Domain.Modules.Almacen.Projections.Almacen;

public class AlmacenDocumentoProjector : DocumentProjector<AlmacenDocumento>
{
    public AlmacenDocumentoProjector()
    {
        Create<AlmacenCreado>(
            (@event, documento) =>
            {
                documento.Id = @event.AggregateId;
                documento.NombreSucursal = @event.NombreSucursal;
                documento.NombreAdministrador = @event.NombreAdministrador;
                documento.Telefono = @event.Telefono;
                documento.Direccion = @event.Direccion;
                documento.Fax = @event.Fax;
                documento.NumeroPedidos = @event.NumeroPedidos;
                documento.Otro = "Otro";
            }
        );

        Deleted<AlmacenEliminado>();
    }
}
