using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Modules.Almacen.Features.CrearAlmacen;

public record CrearAlmacenCommand(
    Guid Id,
    string NombreSucursal,
    string NombreAdministrador,
    string Telefono,
    string Direccion,
    string Fax,
    double? NumeroPedidos
) : ICommand;
