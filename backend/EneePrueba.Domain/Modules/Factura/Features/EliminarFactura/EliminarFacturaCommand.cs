using Enee.Core.CQRS.Command;

namespace EneePrueba.Domain.Modules.Factura.Features.EliminarFactura;

public record EliminarFacturaCommand(Guid Id) : ICommand;
